using DemoProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.EntityFrameworkCore
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
