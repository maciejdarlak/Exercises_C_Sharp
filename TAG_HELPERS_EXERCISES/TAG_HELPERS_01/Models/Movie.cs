using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TAG_HELPERS_01.Models
{
    public class Movie
    {
        [MaxLength(20)]
        [Display(Name = "Movie title:")]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
