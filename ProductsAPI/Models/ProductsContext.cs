using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 1, ProductName = "IPhone 1", Price = 111, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 2, ProductName = "IPhone 2", Price = 222, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 3, ProductName = "IPhone 3", Price = 333, IsActive = false });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 4, ProductName = "IPhone 4", Price = 44, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 5, ProductName = "IPhone 5", Price = 555, IsActive = true });
        }
        public DbSet<Product> Products { get; set; }
    }
}
