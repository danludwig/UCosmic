﻿using System.Web.Mvc;
using System.Web.Routing;
using UCosmic.Www.Mvc.Mappers;

namespace UCosmic.Www.Mvc.Areas.Identity.Mappers
{
    public static class RolesRouteMapper
    {
        private static readonly string Area = MVC.Identity.Name;
        private static readonly string Controller = MVC.Identity.Roles.Name;

        public static void RegisterRoutes(AreaRegistrationContext context)
        {
            DefaultRouteMapper.RegisterRoutes(typeof(RolesRouteMapper), context, Area, Controller);
        }

        // ReSharper disable UnusedMember.Global

        public static class Browse
        {
            public const string Route = "roles";
            private static readonly string Action = MVC.Identity.Roles.ActionNames.Browse;
            public static void MapRoutes(AreaRegistrationContext context, string area, string controller)
            {
                var defaults = new { area, controller, action = Action, };
                var constraints = new { httpMethod = new HttpMethodConstraint("GET") };
                context.MapRoute(null, Route, defaults, constraints);
            }
        }

        public static class Form
        {
            public static readonly string[] Routes = new[] { "roles/{roleNameSlug}/edit/then-go-to/{*returnUrl}", "roles/{roleNameSlug}/edit" };
            private static readonly string Action = MVC.Identity.Roles.ActionNames.Form;
            public static void MapRoutes(AreaRegistrationContext context, string area, string controller)
            {
                var defaultsWithReturnUrl = new
                {
                    area, controller, action = Action,
                };
                var constraintsWithReturnUrl = new
                {
                    httpMethod = new HttpMethodConstraint("GET"),
                    returnUrl = new RawUrlCatchallConstraint(),
                };
                var defaultsWithoutReturnUrl = new
                {
                    area, controller, action = Action,
                    returnUrl = string.Format("/{0}", Browse.Route)
                };
                var constraintsWithoutReturnUrl = new
                {
                    httpMethod = new HttpMethodConstraint("GET"),
                };
                context.MapRoute(null, Routes[0], defaultsWithReturnUrl, constraintsWithReturnUrl);
                context.MapRoute(null, Routes[1], defaultsWithoutReturnUrl, constraintsWithoutReturnUrl);
            }
        }

        public static class Put
        {
            public const string Route = "roles/{roleNameSlug}";
            private static readonly string Action = MVC.Identity.Roles.ActionNames.Put;
            public static void MapRoutes(AreaRegistrationContext context, string area, string controller)
            {
                var defaults = new { area, controller, action = Action };
                var constraints = new
                {
                    httpMethod = new HttpMethodConstraint("POST", "PUT"),
                };
                context.MapRoute(null, Route, defaults, constraints);
            }
        }

        public static class AutoCompleteUserName
        {
            public const string Route = "roles/manage/autocomplete-username.json";
            private static readonly string Action = MVC.Identity.Roles.ActionNames.AutoCompleteUserName;
            public static void MapRoutes(AreaRegistrationContext context, string area, string controller)
            {
                var defaults = new { area, controller, action = Action, };
                var constraints = new { httpMethod = new HttpMethodConstraint("POST") };
                context.MapRoute(null, Route, defaults, constraints);
            }
        }

        public static class AddUserName
        {
            public const string Route = "roles/manage/add-role-member.partial.html";
            private static readonly string Action = MVC.Identity.Roles.ActionNames.AddUserName;
            public static void MapRoutes(AreaRegistrationContext context, string area, string controller)
            {
                var defaults = new { area, controller, action = Action, };
                var constraints = new { httpMethod = new HttpMethodConstraint("GET") };
                context.MapRoute(null, Route, defaults, constraints);
            }
        }

        // ReSharper restore UnusedMember.Global
    }
}