﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SREWT
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Go to the web.config and change default html page if you want to
            /*<defaultDocument>
                <files>
                    <clear/>
                    <add value = "app/index.html" /> 
                </files>
              </defaultDocument>
            */

            routes.IgnoreRoute("app/index.html");
            routes.IgnoreRoute("");
            routes.IgnoreRoute("js/controllers");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}