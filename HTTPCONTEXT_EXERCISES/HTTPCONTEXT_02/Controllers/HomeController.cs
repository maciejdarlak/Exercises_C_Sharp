using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HTTPCONTEXT_02.Models;

namespace HTTPCONTEXT_02.Controllers
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

        // The first method
        [HttpGet]
        public IActionResult FormsTest()
        {
            return View();  
        }

        // The next method - the name "... post" in the method name guarantees that this method has priority.
        [HttpPost]
        public IActionResult FormsTestPost() 
        {
            // HttpContext.Request.Form allows access to USER data (entered in the form).
            return Content("Hello, " + HttpContext.Request.Form["UserName"] + ". You are " + HttpContext.Request.Form["UserAge"] + " years old!");
        }
    }
}
