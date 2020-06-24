using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_CONCEPTS_03.Models
{
    public class WebsiteOptions // This is an object addded to appsettings.json file.
    {
        public WebsiteOptions() { }
        public string Title { get; set; }
        public double Version { get; set; }
    }
}
