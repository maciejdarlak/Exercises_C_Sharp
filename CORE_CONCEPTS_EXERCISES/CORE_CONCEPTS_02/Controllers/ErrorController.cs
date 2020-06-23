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
                // IExceptionHandlerPathFeature - to access information about the exception.
                var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
                // Info for webmaster
                if (exceptionHandlerPathFeature?.Error is FileNotFoundException) 
                {
                    return Content("File error thrown");
                }
                // Info for webmaster
                if (exceptionHandlerPathFeature?.Path == "/index") 
                {
                    return Content("File error thrown from home page");
                }
                // Info for User
                return Content("We're so sorry, but an error just occurred! It has been logged and we'll try to get it fixed ASAP!"); 
            }
        }
    }
}
