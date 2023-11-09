using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrdersSystem.Models;

namespace OrdersSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OrdersSystem.Models.Category>? Category { get; set; }
        public DbSet<OrdersSystem.Models.Customer>? Customer { get; set; }
        public DbSet<OrdersSystem.Models.Employee>? Employee { get; set; }
        public DbSet<OrdersSystem.Models.Order>? Order { get; set; }
        public DbSet<OrdersSystem.Models.OrderDetail>? OrderDetail { get; set; }
        public DbSet<OrdersSystem.Models.Product>? Product { get; set; }
        public DbSet<OrdersSystem.Models.Shipper>? Shipper { get; set; }
        public DbSet<OrdersSystem.Models.Supplier>? Supplier { get; set; }
    }
}