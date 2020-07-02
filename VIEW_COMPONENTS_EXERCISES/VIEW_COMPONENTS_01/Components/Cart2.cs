using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace VIEW_COMPONENTS_01.Components
{
    public class Cart2 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return Content("This is from <h2>View Component</h2>");
        }
    }
}
