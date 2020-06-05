using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAG_HELPERS_01.Models;


namespace TAG_HELPERS_01.Models
{
    public class MovieListViewModel
    {
        public List<Movie> movies { get; set; }
        public string ListTitle { get; set; }
    }
}
