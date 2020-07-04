using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // It has to be added.
using VIEW_COMPONENTS_01.Models;


namespace VIEW_COMPONENTS_01.Components
{
    public class Cart3 : ViewComponent // A partial View id returned.
    {
        public IViewComponentResult Invoke()
        {
            Product[] products = new Product[]
            {
                new Product() { name = "Women Shoes", price = 99 },
                new Product() { name = "Mens Shirts", price = 59 },
                new Product() { name = "Children Belts", price = 19 },
                new Product() { name = "Girls Socks", price = 9 }
            };
            return View(products);
        }
    }
}
