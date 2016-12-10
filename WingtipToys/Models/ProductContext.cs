using System.Data.Entity;
namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("hearthstone") { } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}