using Microsoft.EntityFrameworkCore;

namespace Blazor_Movies_02.Data
{
    public class BlazorMoviesRoadMap : DbContext
    {
        public BlazorMoviesRoadMap(DbContextOptions<BlazorMoviesRoadMap> options)
            : base(options)
        {
        }
        public DbSet<Blazor_Movies_02.Models.RoadMap> RoadMap { get; set; } = default!;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Blazor_Movies_02.Models.RoadMap>().ToTable("RoadMap");
        //}
    }
}
