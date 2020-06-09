using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TAG_HELPERS_02.Models;

namespace TAG_HELPERS_01.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult MovieList()
        {
            MovieListViewModel viewModel = new MovieListViewModel();

            viewModel.MovieUser = new MovieUser() { FirstName = "John", LastName = "Smith", Movie = "1" };

            viewModel.Movies = new List<Movie>()
            { new Movie { Id = 1, Title = "1" },
              new Movie { Id = 2, Title = "2" },
              new Movie { Id = 3, Title = "3" },
              new Movie { Id = 4, Title = "4" } };
            return View(viewModel);
        }
    }
}
