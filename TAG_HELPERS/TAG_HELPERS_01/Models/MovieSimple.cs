using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAG_HELPERS_01.Models
{
    public class MovieSimple
    {
        public string _Title { get; set; }

        public MovieSimple(string Title)
        {
            _Title = Title;
        }
    }
}
