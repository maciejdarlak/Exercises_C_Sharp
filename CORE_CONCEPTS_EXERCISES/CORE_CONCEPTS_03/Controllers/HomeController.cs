using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CORE_CONCEPTS_03.Models;
using Microsoft.Extensions.Configuration;


namespace CORE_CONCEPTS_03.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IConfiguration _configuration;
        // IConfiguration has to be add as a constructor parameter.
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            // Thanks to IConfiguration in constructor parameter is possible to use settings from appsettings.json file, e.g. Website object.
            return Content("Welcome to " + _configuration.GetSection("Website").GetValue<string>("Title") + " version " + _configuration.GetSection("Website").GetValue<string>("Version"));
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
    }
}
