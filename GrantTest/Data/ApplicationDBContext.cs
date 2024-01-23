
using GrantTest.Models;
using Microsoft.EntityFrameworkCore;

namespace GrantTest.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "User 1", Login = "User1", Password = "1111" },
                new User { Id = 2, Name = "User 2", Login = "User2", Password = "2222" }
            );

        modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "SmartTv", Price = 499.99m, CreationDate = DateTime.Now },
                new Product { Id = 2, ProductName = "Iphone", Price = 599.99m, CreationDate = DateTime.Now },
                new Product { Id = 3, ProductName = "Laptop", Price = 399.99m, CreationDate = DateTime.Now },
                new Product { Id = 4, ProductName = "HeadSet HyperX", Price = 59.99m, CreationDate = DateTime.Now },
                new Product { Id = 5, ProductName = "Mouse HyperX", Price = 49.99m, CreationDate = DateTime.Now }
            );
    }
}