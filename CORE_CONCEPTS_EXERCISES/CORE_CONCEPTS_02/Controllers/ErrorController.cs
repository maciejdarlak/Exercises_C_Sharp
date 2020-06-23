using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace CORE_CONCEPTS_02.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            {
                var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>(); // IExceptionHandlerPathFeature - to access information about the exception.
                if (exceptionHandlerPathFeature?.Error is FileNotFoundException) // Info for webmaster
                {
                    return Content("File error thrown");
                }
                if (exceptionHandlerPathFeature?.Path == "/index") // Info for webmaster
                {
                    return Content("File error thrown from home page");
                }
                return Content("We're so sorry, but an error just occurred! It has been logged and we'll try to get it fixed ASAP!"); // Info for User
            }
        }
    }
}
