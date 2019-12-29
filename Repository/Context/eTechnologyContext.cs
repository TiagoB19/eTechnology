using Domain.Entities;
using Domain.paymentObject;
using Microsoft.EntityFrameworkCore;
using Repository.Config;

namespace Repository.Context
{
    public class eTechnologyContext : DbContext

    {
        public eTechnologyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
            modelBuilder.ApplyConfiguration(new ItemProductConfiguration());
            modelBuilder.ApplyConfiguration(new paymentMethodConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> users { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<itemProduct> itemProducts { get; set; }
        public DbSet<paymentMethod> paymentMethod { get; set; }
        
    }
}
