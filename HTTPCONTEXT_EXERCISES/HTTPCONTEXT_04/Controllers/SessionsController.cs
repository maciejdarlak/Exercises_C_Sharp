using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace HTTPCONTEXT_04.Controllers
{
    public class SessionsController : Controller
    {
        public IActionResult Index() // This method tries to get the session data with the GetString() method, using "Name" as the key. 
        {
            string name = HttpContext.Session.GetString("Name");
            return View(model: name); 
        }

        public IActionResult SaveName(string name)
        {
            HttpContext.Session.SetString("Name", name); // This method passing in "Name" as the key and the submitted "name" as the value. 
            return RedirectToAction("Index"); // Then redirects to Index method where the inscription is visible.
        }
    }
}
