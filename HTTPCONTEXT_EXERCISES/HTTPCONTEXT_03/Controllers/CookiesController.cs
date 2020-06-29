using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace HTTPCONTEXT_03.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {          
            if (!HttpContext.Request.Cookies.ContainsKey("first_request")) // The first user visit
            {
                CookieOptions cookieOptions = new CookieOptions(); // It allows you to adjust several important aspects of your cookie, e.g. how long it should stay alive and stuff like domain(s) and path.
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7)); // Adding expire time
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions); // Making cookies + present date
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

