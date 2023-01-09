using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core.Models.Entities;

namespace Nlayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "İphone 14 Pro",
                Stock = 1000,
                Price = 30000,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 2,
                CategoryId = 1,
                Name = "İphone 13",
                Stock = 100,
                Price = 24000,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 3,
                CategoryId = 1,
                Name = "Xiami Note 11",
                Stock = 1300,
                Price = 14000,
                CreatedDate = DateTime.Now,
            }, new Product
            {
                Id = 4,
                CategoryId = 2,
                Name = "Macbook Air",
                Stock = 100,
                Price = 30000,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 5,
                CategoryId = 4,
                Name = "Samsung OLED TV",
                Stock = 10,
                Price = 14000,
                CreatedDate = DateTime.Now
            }, new Product
            {
                Id = 6,
                CategoryId = 3,
                Name = "Apple Watch",
                Stock = 5300,
                Price = 7000,
                CreatedDate = DateTime.Now
            });
        }
    }
}
