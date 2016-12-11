using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		//[Route("{id:int}/{name}")]
		[Route("{id:int}/{name=volga}")]
		public string Test(int id, string name)
		{
			return id.ToString() + ". " + name;
		}
		
		[Route("{id:int}")]
		public string Sead(int id)
		{
			return id.ToString();
		}

		[Route("~/lol/twit/{id:int}")]
		public string Twit(int id)
		{
			return id.ToString();
		}
	}
}