using Microsoft.EntityFrameworkCore;
using NLayer.Core;

namespace NLayer.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //public DbSet<ProductFeature> ProductFeatures { get; set; }
    }
}
