using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebStore.Models;


namespace WebStore2.DAL
{
	public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
	{
		protected override void Seed(StoreContext context)
		{
			var products = new List<Product>
			{
				new Product {Id = 1, Name = "Sófi", CategoryId = 1, Description = "Hellað flott zebra leðursófi", Price = 200, Stock = 99 }
			};
			products.ForEach(s => context.Products.Add(s));
			context.SaveChanges();
			var categories = new List<Category>
			{
				new Category {Name = "Books "},
				new Category { Name = "Movies, Music & Games" },
				new Category {Name = "Electronics & Computers" },
				new Category {Name = "Home, Garden & Tools" },
				new Category {Name = "Beauty, Health & Grocery" },
				new Category {Name = "Toys, Kids & Baby" },
				new Category {Name = "Clothing, Shoes & Jewelry" },
				new Category {Name = "Sport & Outdoors<" },
				new Category {Name = "Automotive & Industrial" }
			};
			categories.ForEach(c => context.Categories.Add(c));
			context.SaveChanges();
		}
	}
}