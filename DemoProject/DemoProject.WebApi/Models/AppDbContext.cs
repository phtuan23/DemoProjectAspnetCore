using DemoProject.WebApi.Services.PasswordHasher;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.WebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User() { Id = "56b6560c-be94-4f04-8996-9080897ecd8f", Name = "Pham Anh Tuan", Email = "tuan@gmail.com", Password = PasswordHasher.HashPassword("123456"), Role = "Admin" },
                new User() { Id = "6c24e5a8-cad1-4558-bace-c204b701b790", Name = "Nguyen Van Dung", Email = "dung@gmail.com", Password = PasswordHasher.HashPassword("123456"), Role = "User" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = "1fc0f571-ee95-46e2-ba61-483dc5355620", Name = "Product 1", Price = 100000, Quantity = 100, Description = "New Product 1"},
                new Product() { Id = "33aa75b9-e581-4d5a-8904-8c131143fbf3", Name = "Product 2", Price = 200000, Quantity = 100, Description = "New Product 2"},
                new Product() { Id = "59ace14e-85c0-487b-a890-4d8fe98d5e53", Name = "Product 3", Price = 300000, Quantity = 100, Description = "New Product 3"},
                new Product() { Id = "83764b22-8da9-4ffe-a5df-14d3fe8fc558", Name = "Product 4", Price = 400000, Quantity = 100, Description = "New Product 4"}
            );
        }
    }
}
