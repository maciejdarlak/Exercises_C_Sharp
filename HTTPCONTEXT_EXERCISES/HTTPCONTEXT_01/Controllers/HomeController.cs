using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HTTPCONTEXT_01.Models;

namespace HTTPCONTEXT_01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult QueryTest()
        {
            string firstName = "Maciek";
            string lastName = "Darlak";

            // The Request property provides access to the properties and methods of the HttpRequest class, the Query property allows to easily access keys and their values. 
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["firstName, lastName"]))
            {
                firstName = HttpContext.Request.Query["firstName"];
                lastName = HttpContext.Request.Query["lastName"];
            }
            return Content("Name is " + firstName + " " + lastName);
        }
    }
}
