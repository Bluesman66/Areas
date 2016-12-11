using Areas.RouteHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Areas
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//routes.MapRoute(
			//	name: "Default",
			//	url: "{controller}/{action}/{id}",
			//	defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
			//	namespaces: new[] { "Areas.Controllers" }
			//	//namespaces: new[] { "Areas.Areas.Store.Controllers" }
			//);
			
			Route newRoute = new Route("{controller}/{action}", 
				new RouteValueDictionary(new { controller = "Home", action = "Index", id = UrlParameter.Optional }),  
				new MyRouteHandler());
			routes.Add(newRoute);
		}
	}
}
