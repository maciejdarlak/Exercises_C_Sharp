//Write a program in C# Sharp to find the string which starts and ends with a specific character. 

using System;
using System.Linq;


// StartsWith () and EndsWith (endLetter) catch start and end characters even though it's a string, not a char

namespace LINQ6
{
    class LINQ6
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string[] array = new string[] { "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"


                string startLetter = "A";
                string endLetter = "M";

                var word = array.Select(a => a).Where(a => a.StartsWith(startLetter) && a.EndsWith(endLetter));

                foreach (var item in word)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
        }
    }
}
