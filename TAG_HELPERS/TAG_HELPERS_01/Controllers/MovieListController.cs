﻿using System;
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

            viewModel.MovieUser = new MovieUser() { FirstName = "John", LastName = "Smith", Movie = "1"};

            viewModel.Movies = new List<Movie>();
            viewModel.Movies.Add(new Movie() { Title = "1" });
            viewModel.Movies.Add(new Movie() { Title = "2" });
            viewModel.Movies.Add(new Movie() { Title = "3" });
            viewModel.Movies.Add(new Movie() { Title = "4" });
            return View(viewModel);
        }
    }
}
