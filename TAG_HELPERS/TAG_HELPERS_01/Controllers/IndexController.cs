using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TAG_HELPERS_01.Models;

namespace TAG_HELPERS_01.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(movie);
        }
    }
}