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
    }
}
