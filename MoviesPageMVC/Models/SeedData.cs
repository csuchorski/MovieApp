using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesPageMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPageMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MoviesPageMVCContext(
                serviceProvider.GetRequiredService<DbContextOptions<MoviesPageMVCContext>>());
            if(context.Movie.Any())
            {
                return;
            }

            context.Movie.Add(new Movie { Name = "When Harry Met Sally", Genre = "Comedy", ReleaseDate = DateTime.Parse("1989 - 2 - 12"), Price = 9.9M });
            context.Movie.Add(new Movie { Name = "Once upon a time in Hollywood", Genre = "Action", ReleaseDate = DateTime.Parse("2019-5-21"), Price = 89.9M });
            context.Movie.Add(new Movie { Name = "Ghostbusters 2", ReleaseDate = DateTime.Parse("1986-2-23"), Genre = "Comedy", Price = 9.99M});
            context.Movie.Add(new Movie { Name = "Rio Bravo", Genre = "Western", ReleaseDate = DateTime.Parse("1959-4-15"), Price = 3.9M });

            context.SaveChanges();
        }
    }
}
