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
            if (!HttpContext.Request.Cookies.ContainsKey("first_request")) // The first user visit - first_request (its value is first visit date) doesn't exist yet.
            {
                CookieOptions cookieOptions = new CookieOptions(); // It allows you to adjust several important aspects of your cookie, and others (https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.cookieoptions?view=aspnetcore-3.1).
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7)); // Adding expire time.
                cookieOptions.Domain = ".darlak.com"; // The cookie will be accessible from mywebsite.com as well as all possible subdomains.
                cookieOptions.Path = "/users"; // The cookie will now only be visible and readable to pages in the "users" folder, as well as sub-folders to it.

                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions); // Making cookies + present date.
                return Content("Welcome, new visitor!");
            }
            else // The next user visit.
            {
                DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_request"]); // Change the format to DateTime (file_request is a key, datetime is a value).
                return Content("Welcome back, user! You first visited us on: " + firstRequest.ToString()); // Change the format to String.
            }
        }
    }
}

