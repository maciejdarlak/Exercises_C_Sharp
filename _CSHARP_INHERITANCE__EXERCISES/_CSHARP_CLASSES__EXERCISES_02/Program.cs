using System;
using System.Collections.Generic;

namespace _CSHARP_CLASSES__EXERCISES_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // taking a string variable 
            string str1 = "GFG";

            // taking an Object type variable 
            // assigning var1 to it 
            object obj1 = str1;

            // now try it to cast to a string 
            string str2 = obj1 as string;

            // checking Successfully cast or not 
            if (str2 != null)
            {
                Console.WriteLine("Successfully Cast");
            }

            // now try to cast it to List 
            List<string> mylist = obj1 as List<string>;

            // checking Successfully cast or not 
            if (mylist != null)
            {
                Console.WriteLine("Successfully Cast");
            }
            else
            {
                Console.WriteLine("Not Successfull");
            }
        }
    }
}
