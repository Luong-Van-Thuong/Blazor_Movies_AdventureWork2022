using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazor_Movies_02.Models;

namespace Blazor_Movies_02.Data
{
    public class BlazorMovies02Context : DbContext
    {
        public BlazorMovies02Context (DbContextOptions<BlazorMovies02Context> options)
            : base(options)
        {
        }

        public DbSet<Blazor_Movies_02.Models.Model> Model { get; set; } = default!;
    }
}
