﻿using System.Web.Mvc;
using System.Web.Routing;
using UCosmic.Domain.Establishments;
using UCosmic.Domain.Identity;
using UCosmic.Www.Mvc.Controllers;

namespace UCosmic.Www.Mvc.Areas.Identity.Controllers
{
    public class ReceiveSamlAuthnResponseServices
    {
        public ReceiveSamlAuthnResponseServices(IProcessQueries queryProcessor
            , ISignUsers userSigner
            , IProvideSaml2Service samlServiceProvider
            , IHandleCommands<ReceiveSamlAuthnResponseCommand> commandHandler
        )
        {
            QueryProcessor = queryProcessor;
            UserSigner = userSigner;
            SamlServiceProvider = samlServiceProvider;
            CommandHandler = commandHandler;
        }

        public IProcessQueries QueryProcessor { get; private set; }
        public ISignUsers UserSigner { get; private set; }
        public IProvideSaml2Service SamlServiceProvider { get; private set; }
        public IHandleCommands<ReceiveSamlAuthnResponseCommand> CommandHandler { get; private set; }
    }

    public partial class ReceiveSamlAuthnResponseController : BaseController
    {
        private readonly ReceiveSamlAuthnResponseServices _services;

        public ReceiveSamlAuthnResponseController(ReceiveSamlAuthnResponseServices services)
        {
            _services = services;
        }

        [HttpPost]
        public virtual ActionResult Post()
        {
            // use HttpContext to create a SamlResponse
            var samlResponse = _services.SamlServiceProvider
                .ReceiveSamlResponse(Saml2SsoBinding.HttpPost, HttpContext);

            // execute command on the saml response object
            _services.CommandHandler.Handle(
                new ReceiveSamlAuthnResponseCommand
                {
                    SamlResponse = samlResponse,
                }
            );

            // flash the success message
            SetFeedbackMessage(string.Format(
                SignOnController.SuccessMessageFormat,
                    samlResponse.EduPersonPrincipalName));

            // redirect after sign on
            var establishment = _services.QueryProcessor.Execute(
                new EstablishmentBySamlEntityId
                {
                    SamlEntityId = samlResponse.IssuerNameIdentifier,
                }
            );

            var returnUrl = samlResponse.RelayResourceUrl ??
                            _services.UserSigner.DefaultSignedOnUrl;

            if (Request.Url != null)
            {
                if (Request.Url.Host == "preview.ucosmic.com" && returnUrl.StartsWith("https://alpha.ucosmic.com"))
                {
                    return
                        Redirect(string.Format("https://alpha.ucosmic.com/sign-in/tenantize/?returnUrl={0}",
                            Server.UrlEncode(returnUrl)));
                }
                if (Request.Url.Host == "preview.ucosmic.com" && returnUrl.StartsWith("https://alpha-staging.ucosmic.com"))
                {
                    return
                        Redirect(string.Format("https://alpha-staging.ucosmic.com/sign-in/tenantize/?returnUrl={0}",
                            Server.UrlEncode(returnUrl)));
                }
                if (Request.Url.Host == "develop.ucosmic.com" &&
                         (returnUrl.StartsWith("https://spike.ucosmic.com") ||
                          returnUrl.StartsWith("http://spike.ucosmic.com")))
                {
                    return
                        Redirect(string.Format("https://spike.ucosmic.com/sign-in/tenantize/?returnUrl={0}",
                            Server.UrlEncode(returnUrl)));
                }
            }

            var skinsUrl = Url.Action(MVC.Common.Skins.Change(establishment.WebsiteUrl, returnUrl));
            return Redirect(skinsUrl);
        }
    }

    public static class ReceiveSamlAuthnResponseRouter
    {
        private static readonly string Area = MVC.Identity.Name;
        private static readonly string Controller = MVC.Identity.ReceiveSamlAuthnResponse.Name;

        public class PostRoute : MvcRoute
        {
            public PostRoute()
            {
                Url = "sign-on/saml/2/post";
                DataTokens = new RouteValueDictionary(new { area = Area });
                Defaults = new RouteValueDictionary(new
                {
                    controller = Controller,
                    action = MVC.Identity.ReceiveSamlAuthnResponse.ActionNames.Post,
                });
                Constraints = new RouteValueDictionary(new
                {
                    httpMethod = new HttpMethodConstraint("POST"),
                });
            }
        }
    }
}
