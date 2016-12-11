using Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Areas.Controllers
{
	public class HomeController : Controller
	{
		BookContext db = new BookContext();

		public ActionResult Index()
		{
			return View();
		}

		[Route("book/{id}")]
		public ActionResult GetBook(int? id)
		{
			if (id == null)
				return HttpNotFound();
			Book book = db.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);
			if (book == null)
				return HttpNotFound();
			return View(book);
		}

		[Route("book/{id}/author")]
		public ActionResult GetAuthor(int? id)
		{
			if (id == null)
				return HttpNotFound();
			Book book = db.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);
			if (book == null)
				return HttpNotFound();
			return View(book.Author);
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