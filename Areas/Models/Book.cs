﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Areas.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int AuthorId { get; set; }
		public Author Author { get; set; }
	}
}