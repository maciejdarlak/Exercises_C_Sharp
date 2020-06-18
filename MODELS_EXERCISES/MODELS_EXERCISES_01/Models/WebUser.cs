using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MODELS_EXERCISES_01.Models
{
    public class WebUser
    { 
        [Required(ErrorMessage = "You must enter a value for the First Name field!")]
        [StringLength(25, ErrorMessage = "The First Name must be no longer than 25 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a value for the Last Name field!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Last Name must be between 3 and 50 characters long!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter a value for the Mail Address field!")]
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail address!")]
        public string MailAddress { get; set; }
    }
}
