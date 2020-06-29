using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HTTPCONTEXT_03.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("first_request")) // The first user visit
            {
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString()); // Making cookies + present date
                return Content("Welcome, new visitor!");
            }
            else // The next user visit
            {
                DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_request"]); // Change the format to DateTime (file_request is a key, datetime is a value).
                return Content("Welcome back, user! You first visited us on: " + firstRequest.ToString()); // Change the format to String
            }
        }
    }
}

