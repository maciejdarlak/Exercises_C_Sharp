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
            MovieListViewModel viewModel = new MovieListViewModel();

            viewModel.ListTitle = "Best List";

            viewModel.movies = new List<Movie>();
            viewModel.movies.Add(new Movie() { Title = "1" });
            viewModel.movies.Add(new Movie() { Title = "2" });
            viewModel.movies.Add(new Movie() { Title = "3" });
            viewModel.movies.Add(new Movie() { Title = "4" });
            return View(viewModel);
        }
    }
}
