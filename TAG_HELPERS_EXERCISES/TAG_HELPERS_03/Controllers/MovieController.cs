using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TAG_HELPERS_03.Models;

namespace TAG_HELPERS_03.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult List()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie() { Id = 1, Title = "Fight Club" },
                new Movie() { Id = 2, Title = "Forrest Gump" },
                new Movie() { Id = 3, Title = "The Godfather" },
            };
           return View(movies);
        }
    }
}