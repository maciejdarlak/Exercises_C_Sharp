using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MODELS_EXERCISES_01.Models;


namespace MODELS_EXERCISES_01.Controllers
{
    public class ValidationController : Controller
    {
        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SimpleValidation(WebUser webUser)
        {
            if (ModelState.IsValid)
            {
                return Content("Thank you.");
            }
            else
                return View(webUser);
        }
    }
}
