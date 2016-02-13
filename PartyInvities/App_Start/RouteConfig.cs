using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PartyInvities
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Content/{filename}.html");

            //routes.MapRoute(
            //    name: "OakGroveHome",
            //    url: "App/Blah/{controller}/{action}/{rpid}",
            //    defaults: new { controller = "OakGrove" }
            //);
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );

            //routes.MapRoute(
            //    name: "OakGrove",
            //    url: "{controller}",
            //    defaults: new { controller = "Home", action = "Index", id = 5 }
            //);
        }
    }
}
