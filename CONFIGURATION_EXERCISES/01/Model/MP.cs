using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace _01.Model
{
    public class MP
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "varchar")]
        public string CODE { get; set; }
    }
}
