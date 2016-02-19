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

			routes.MapRoute(null, "{controller}/{action}");

			//routes.MapRoute(
			//	name: "Default",
			//	url: "{controller}/{action}",
			//	defaults: new { controller = "RentalProp", action = "Index" }
			//);

			//routes.MapRoute(
			//    name: "OakGrove",
			//    url: "App/Blah/{controller}",
			//    defaults: new { controller = "Home", action = "Index", id = 5 }
			//);
		}
	}
}
