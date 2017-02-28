
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebStore.Models;

namespace WebStore2.DAL
{
	public class StoreContext : DbContext
	{
		public StoreContext() : base("StoreContext")
        {
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}