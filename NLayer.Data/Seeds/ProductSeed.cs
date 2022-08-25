using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Data.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Kalem1", Price = 100, Stock = 10, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 2, Name = "Silgi1", Price = 50, Stock = 150, CreatedDate = DateTime.Now });
        }
    }
}
