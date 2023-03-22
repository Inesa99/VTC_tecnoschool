using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }
    }
}
