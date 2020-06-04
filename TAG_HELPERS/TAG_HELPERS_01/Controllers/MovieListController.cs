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
            var movieList = new List<MovieSimple>();
            movieList.Add(new MovieSimple("1"));
            movieList.Add(new MovieSimple("2"));
            movieList.Add(new MovieSimple("3"));
            movieList.Add(new MovieSimple("4"));
            return View(movieList);
        }
    }
    }
