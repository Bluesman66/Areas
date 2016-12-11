using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Areas.Models
{
	public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
	{
		protected override void Seed(BookContext db)
		{
			db.Authors.Add(new Author { Id = 1, Name = "Л. Толстой" });
			db.Authors.Add(new Author { Id = 2, Name = "И. Тургенев" });
			db.Authors.Add(new Author { Id = 3, Name = "А. Чехов" });

			db.Books.Add(new Book { Id = 1, Name = "Война и мир", Price = 220, AuthorId = 1 });
			db.Books.Add(new Book { Id = 2, Name = "Отцы и дети", Price = 180, AuthorId = 2 });
			db.Books.Add(new Book { Id = 3, Name = "Чайка", Price = 150, AuthorId = 3 });

			base.Seed(db);
		}
	}
}