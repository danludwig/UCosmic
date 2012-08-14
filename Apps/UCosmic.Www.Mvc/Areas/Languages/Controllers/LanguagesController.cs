﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using UCosmic.Domain.Languages;
using UCosmic.Www.Mvc.Areas.Languages.Models;
using UCosmic.Www.Mvc.Controllers;
using UCosmic.Domain.Identity;
using UCosmic.Www.Mvc.Models;

namespace UCosmic.Www.Mvc.Areas.Languages.Controllers
{
    [Authenticate]
    public partial class LanguagesController : Controller
    {
        private readonly IProcessQueries _queries;

        public LanguagesController(IProcessQueries queries)
        {
            _queries = queries;
        }

        [HttpGet]
        //[OutputCache(VaryByParam = "*", Duration = 5)]
        public virtual ActionResult Get(LanguagesRequest inputs)
        {
            if (!Request.IsAjaxRequest())
            {
                var preferences = _queries.Execute(new MyPreferencesByCategory(User) { Category = PreferenceCategory.Languages });
                var lens = preferences.ByKey(PreferenceKey.EnumeratedViewLayout).SingleOrDefault();
                var pageSize = preferences.ByKey(PreferenceKey.PageSize).SingleOrDefault();
                return View(Views.get, new LanguagesLayout
                {
                    Lens = lens != null ? lens.Value.AsEnum<ItemsLens>() : ItemsLens.Table,
                    SelectedPageSize = pageSize != null ? pageSize.Value.ParseIntoInt(10) : 10,
                });
            }

            //Thread.Sleep(800);
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
            Expression<Func<LanguageName, bool>> translatedName = n => n.TranslationToLanguage.TwoLetterIsoCode.Equals(
                CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase);
            var entities = _queries.Execute(new LanguagesByKeyword(inputs.Keyword)
            {
                PagerOptions = new PagerOptions
                {
                    PageSize = inputs.PageSize,
                    PageNumber = inputs.PageNumber,
                },
                EagerLoad = new Expression<Func<Language, object>>[]
                {
                    l => l.Names.Select(n => n.TranslationToLanguage)
                },
                OrderBy = new Dictionary<Expression<Func<Language, object>>, OrderByDirection>
                {
                    { l => l.TwoLetterIsoCode.Equals(
                        CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, StringComparison.OrdinalIgnoreCase),
                            OrderByDirection.Descending },
                    { l => l.Names.Count,
                            OrderByDirection.Descending },
                    { l => l.Names.AsQueryable().FirstOrDefault(translatedName) != null
                        ? l.Names.AsQueryable().FirstOrDefault(translatedName).Text : null,
                            OrderByDirection.Ascending },
                },
            });
            var model = Mapper.Map<LanguageResults>(entities);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }

    public static class LanguagesRouter
    {
        private static readonly string Area = MVC.Languages.Name;
        private static readonly string Controller = MVC.Languages.Languages.Name;

        public class GetRoute : MvcRoute
        {
            public GetRoute()
            {
                Url = "languages";
                DataTokens = new RouteValueDictionary(new { area = Area, });
                Defaults = new RouteValueDictionary(new
                {
                    controller = Controller,
                    action = MVC.Languages.Languages.ActionNames.Get,
                });
                Constraints = new RouteValueDictionary(new
                {
                    httpMethod = new HttpMethodConstraint("GET")
                });
            }
        }
    }
}
