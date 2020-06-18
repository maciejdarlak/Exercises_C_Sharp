using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ROUTING_EXERCISES_02.Controllers
{
    public class CountryControllerc : Controller
    {
        /*
         With this in place, the first parameter has to be of the integer data type and must be between 1 and 999999. 
         The second parameter defaults to a string, since no data type is specified, and it has to be at least 3 characters long but no longer than 50 characters.
         */
        [Route("/Poland/{entryId:int:range(1, 999999)}/{slug:minlength(3):maxlength(50)}")]
        public IActionResult Poland(int entryId, string slug)
        {
            return Content($"Poland with ID #{entryId} requested (URL Slug: {slug})");
        }

        /*
           Substitutes of entryId:
                {isVisible:bool}
                {entryDate:datetime}
                {weight:double}
                {weight:float}
                {price:decimal}
                {id:guid}
                {postId:long}
        */

        // This is a new URL for this method = .../poland/any int/ OPTIONAL any string ("?" would provide optional "slug" using).
        // This is a new URL for this method = .../poland/any int/any string ("*" would provide the possibility of using "/" in a variable "slug").
    }
}
