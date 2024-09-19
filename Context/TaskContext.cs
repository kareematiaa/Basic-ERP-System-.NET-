using Microsoft.EntityFrameworkCore;
using Task1.Entities;

namespace Task1.Context;

public class TaskContext : DbContext
{
    public DbSet<OrderHeaders> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }

    public TaskContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskContext).Assembly);

        // Configure One-to-Many: Customer - Order
        modelBuilder.Entity<OrderHeaders>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure One-to-Many: Order - OrderDetail
        modelBuilder.Entity<OrderDetails>()
            .HasOne(od => od.OrderHeaders)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configure One-to-Many: Product - OrderDetail
        modelBuilder.Entity<OrderDetails>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductId);
    }
}

