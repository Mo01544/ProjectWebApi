using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWebAPI.SharedClasses;

namespace Project.Models
{
        public class ProductEntity : IdentityDbContext<ApplicationUser>
        {

            public ProductEntity()
            {
            }
            public ProductEntity (DbContextOptions options) : base(options)
            {
            }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderProduct>()
                .HasKey(or => new { or.OrderId, or.ProductId });
        }
        public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrdersProducts { get; set; }
    }
}
