using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesPageMVC.Models;

namespace MoviesPageMVC.Data
{
    public class MoviesPageMVCContext : DbContext
    {
        public MoviesPageMVCContext (DbContextOptions<MoviesPageMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesPageMVC.Models.Movie> Movie { get; set; }
    }
}
