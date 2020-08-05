using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DI_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI_01.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Products); //References directly to the Products property when an object is created.
        }
    }
}
