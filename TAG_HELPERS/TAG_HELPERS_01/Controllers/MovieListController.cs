using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TAG_HELPERS_01.Models;

namespace TAG_HELPERS_01.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult MovieList()
        {
            MovieList x = new MovieList() { Title = "1" };
            List<MovieList> movies = new List<MovieList>();
            movies.Add(new MovieList() { Title = "1" });
            movies.Add(new MovieList() { Title = "2" });
            movies.Add(new MovieList() { Title = "3" });
            movies.Add(new MovieList() { Title = "4" });
            return View();
        }
    }
}
