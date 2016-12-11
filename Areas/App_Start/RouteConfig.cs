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
			//	name: "Default2",
			//	url: "{id}/{name}",
			//	defaults: new { controller = "Home", action = "Test" },
			//	constraints: new { id = "\\d+" },
			//	namespaces: new[] { "Areas.Controllers" }
			//);

			routes.MapMvcAttributeRoutes();

			//routes.MapRoute(
			//	name: "author",
			//	url: "book/{id}/author",
			//	defaults: new { controller = "Home", action = "GetAuthor" }
			//);

			//routes.MapRoute(
			//	name: "book",
			//	url: "book/{id}",
			//	defaults: new { controller = "Home", action = "GetBook" }
			//);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				namespaces: new[] { "Areas.Controllers" }			
			);

			//Route newRoute = new Route("{controller}/{action}",
			//	new RouteValueDictionary(new { controller = "Home", action = "Index", id = UrlParameter.Optional }),
			//	new MyRouteHandler());
			//routes.Add(newRoute);
		}
	}
}
