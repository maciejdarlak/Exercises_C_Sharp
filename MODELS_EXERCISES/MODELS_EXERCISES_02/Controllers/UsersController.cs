using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MODELS_EXERCISES_02.Models;


namespace MODELS_EXERCISES_02.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WebUser webUser)
        {
            if (ModelState.IsValid)
            {
                return Content("Thank you.");
            }
            else
            {
                return View(webUser);
            }
        }
    }
}
