using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesPageMVC.Models
{
    public class MovieGenreViewModel
    {
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public List<Movie> MovieList { get; set; }
        public SelectList Genres { get; set; }
    }
}
