using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ROUTING_EXERCISES_01.Models;

namespace ROUTING_EXERCISES_01.Controllers
{
    [Route("/countries")]
    public class CountryController : Controller
    {
        public IActionResult List()
        {
            List<Country> countries = new List<Country>()
            {
                new Country() { Id=1, Name="Spain" },
                new Country() { Id=2, Name="Italy" }
            };
            return View(countries);
        }

        [Route("/cities")] //This is a new URL for this method = the old one .../country/List --> the new one .../countries
        public IActionResult List2()
        {
            List<Country> countries = new List<Country>()
            {
                new Country() { Id=1, City="Barcelona" },
                new Country() { Id=2, City="Rome" }
            };
            return View(countries);
        }

        [Route("{Id}")]
        public IActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }
    }
}
