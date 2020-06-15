using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ROUTING_EXERCISES_01.Models;

namespace ROUTING_EXERCISES_01.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product overview");
        }

        public IActionResult List()
        {
            List<Country> countries = new List<Country>()
            {
                new Country() { Id=1, Name="Spain", City="Barcelona" },
                new Country() { Id=2, Name="Italy", City="Rome" }
            };
            return View(countries);
        }

        public IActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }

        public IActionResult Word()
        {
            return View();
        }
    }
}
