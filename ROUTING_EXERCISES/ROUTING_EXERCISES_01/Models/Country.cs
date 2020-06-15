using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ROUTING_EXERCISES_01.Models
{
    [Route("/countries")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
