using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ROUTING_EXERCISES_01.Models;

namespace ROUTING_EXERCISES_01.Controllers
{
    [Route("/cc")] // This is a new URL for this class = the old one .../country --> the new one .../cc
    public class CountryController : Controller
    {
        [Route("/countries")] // This is a new URL for this method = the old one .../country/list --> the new one .../countries
        public IActionResult List()
        {
            List<Country> countries = new List<Country>()
            {
                new Country() { Id=1, Name="Spain" },
                new Country() { Id=2, Name="Italy" }
            };
            return View(countries);
        }

        [Route("/cities")] 
        public IActionResult List2()
        {
            List<Country> countries = new List<Country>()
            {
                new Country() { Id=1, City="Barcelona" },
                new Country() { Id=2, City="Rome" }
            };
            return View(countries);
        }

        [Route("{Id}")] // That method will be called as "any URL word" after .../cc/"any URL word"
        public IActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }
    }
}
