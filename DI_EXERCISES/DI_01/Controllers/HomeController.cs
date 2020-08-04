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
        public IActionResult Index()
        {
            return View(new Repository().Products); //References directly to the Products property when an object is created.
        }
    }
}
