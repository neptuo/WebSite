﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Neptuo.WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Old urls


            //Custom routes

            routes.MapRoute(
                name: "Webs",
                url: "webs",
                defaults: new { controller = "Content", action = "Webs" }
            );

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Content", action = "Home" }
            );

            routes.MapRoute(
                name: "ContentFallBack",
                url: "{*path}",
                defaults: new { controller = "Content", action = "Index" }
            );
        }
    }
}