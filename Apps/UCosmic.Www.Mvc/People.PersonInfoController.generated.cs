// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace UCosmic.Www.Mvc.Areas.People.Controllers {
    public partial class PersonInfoController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PersonInfoController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult ByEmail() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.ByEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult ByGuid() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.ByGuid);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult WithEmail() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.WithEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult WithFirstName() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.WithFirstName);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult WithLastName() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.WithLastName);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PersonInfoController Actions { get { return MVC.People.PersonInfo; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "People";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "PersonInfo";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "PersonInfo";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string ByEmail = "ByEmail";
            public readonly string ByGuid = "ByGuid";
            public readonly string WithEmail = "WithEmail";
            public readonly string WithFirstName = "WithFirstName";
            public readonly string WithLastName = "WithLastName";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string ByEmail = "ByEmail";
            public const string ByGuid = "ByGuid";
            public const string WithEmail = "WithEmail";
            public const string WithFirstName = "WithFirstName";
            public const string WithLastName = "WithLastName";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_PersonInfoController: UCosmic.Www.Mvc.Areas.People.Controllers.PersonInfoController {
        public T4MVC_PersonInfoController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.JsonResult ByEmail(string email) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.ByEmail);
            callInfo.RouteValueDictionary.Add("email", email);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult ByGuid(System.Guid guid) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.ByGuid);
            callInfo.RouteValueDictionary.Add("guid", guid);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult WithEmail(string term, UCosmic.Domain.StringMatchStrategy matchStrategy) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.WithEmail);
            callInfo.RouteValueDictionary.Add("term", term);
            callInfo.RouteValueDictionary.Add("matchStrategy", matchStrategy);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult WithFirstName(string term, UCosmic.Domain.StringMatchStrategy matchStrategy) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.WithFirstName);
            callInfo.RouteValueDictionary.Add("term", term);
            callInfo.RouteValueDictionary.Add("matchStrategy", matchStrategy);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult WithLastName(string term, UCosmic.Domain.StringMatchStrategy matchStrategy) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.WithLastName);
            callInfo.RouteValueDictionary.Add("term", term);
            callInfo.RouteValueDictionary.Add("matchStrategy", matchStrategy);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
