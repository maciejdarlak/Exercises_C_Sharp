using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CORE_CONCEPTS_03.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;  // It has to be added.


namespace CORE_CONCEPTS_03.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly WebsiteOptions _websiteOptions;
        // IOptions<WebsiteOptions> has to be added as a constructor parameter (which allows getting WebsiteOptions from ConfigureServices method from StartUp file).
        public HomeController(IOptions<WebsiteOptions> websiteOptions)
        {
            this._websiteOptions = websiteOptions.Value;
        }

        public IActionResult Index()
        {
            // Thanks to constructor parameter is possible to use proporties from appsettings.json file via actions in StartUp file.
            return Content("Welcome to " + _websiteOptions.Title + " version " + _websiteOptions.Version);
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
