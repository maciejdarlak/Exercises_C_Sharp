using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DI_01.Controllers
{
    /*
     * It is possible to declare dependencies using an action method instead of a constructor - good for application performance.
      So only the particular action method causes the implementation type to initiate. 
      This means the dependency is not resolved on every time the Controller is called:

        public class HomeController : Controller
        {
            private IRepository repository;
            public HomeController(IRepository repo)
            {
                repository = repo;
            }
  
            public IActionResult Index([FromServices] ProductSum productSum)
            {
                // ViewBag.Total = productSum.Total;
                ViewBag.HomeControllerGuid = repository.ToString();
                ViewBag.TotalGuid = productSum.Repository.ToString();
                return View(repository.Products);
            }
         }
     */

    public class HomeController : Controller
    {
        private IRepository repository;
        private ProductSum productSum;
        public HomeController(IRepository repo, ProductSum psum)
        {
            repository = repo;
            productSum = psum;
        }
        public IActionResult Index()
        {
            // ViewBag.Total = productSum.Total;
            ViewBag.HomeControllerGuid = repository.ToString();
            ViewBag.TotalGuid = productSum.Repository.ToString();
            return View(repository.Products); //References directly to the Products property when an object is created.
        }
    }
}
