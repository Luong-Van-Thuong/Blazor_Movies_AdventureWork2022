using Blazor_Movies_02.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Movies_02.Data
{
    public class AdventureWorks2022 : DbContext
    {
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<ProductInventory> ProductInventories { get; set; } = default!;
        public DbSet<Location> Locations { get; set; } = default!;


        public AdventureWorks2022(DbContextOptions<AdventureWorks2022> options)
            : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>()
        //        .ToTable("Product", "Production");
        //    modelBuilder.Entity<ProductInventory>()
        //        .ToTable("ProductInventory", "Production");
        //    modelBuilder.Entity<Location>()
        //        .ToTable("Location", "Production");

        //    modelBuilder.Entity<ProductInventory>()
        //        .HasKey(pi => new { pi.ProductID, pi.LocationID });

        //    modelBuilder.Entity<ProductInventory>()
        //        .HasOne(pi => pi.Product)
        //        .WithMany(p => p.ProductInventories)
        //        .HasForeignKey(pi => pi.ProductID);

        //    modelBuilder.Entity<ProductInventory>()
        //        .HasOne(pi => pi.Location)
        //        .WithMany(l => l.ProductInventories)
        //        .HasForeignKey(pi => pi.LocationID);

        //    //base.OnModelCreating(modelBuilder);
        //}
    }
}
