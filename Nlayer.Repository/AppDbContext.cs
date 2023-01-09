using Microsoft.EntityFrameworkCore;
using Nlayer.Core.Models.Entities;
using Nlayer.Repository.Configurations;
using System.Reflection;

namespace Nlayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//Configuration dan kalıtım almış dosyalarını tek seferde tarar.
                                                                                          // modelBuilder.ApplyConfiguration(new ProductConfig());//Tek tek taramak için kullanılan yöntem
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature
            {
                Id=1,
                ProductId=1,
                Color="Rose",
                Height=198,
                Width=13
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
