using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core.Models.Entities;

namespace Nlayer.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = 1,
                Name = "Telefonlar",
                CreatedDate = DateTime.Now,

            },
            new Category
            {
                Id = 2,
                Name = "Bilgisayarlar",
                CreatedDate = DateTime.Now,
            },
            new Category
            {
                Id = 3,
                Name = "Akıllı Saatler"
            },
            new Category
            {
                Id = 4,
                Name = "Televizyonar"
                ,
                CreatedDate = DateTime.Now,
            });
        }
    }
}
