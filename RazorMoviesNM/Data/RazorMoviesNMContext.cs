#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorMoviesNM.Models;

namespace RazorMoviesNM.Data
{
    public class RazorMoviesNMContext : DbContext
    {
        public RazorMoviesNMContext (DbContextOptions<RazorMoviesNMContext> options)
            : base(options)
        {
        }

        public DbSet<RazorMoviesNM.Models.Movie> Movie { get; set; }
    }
}
