using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace VIEW_COMPONENTS_01.Components
{
    public class Cart : ViewComponent
    {
        public string Invoke()
        {
            return "This is from View Component";
        }
    }
}
