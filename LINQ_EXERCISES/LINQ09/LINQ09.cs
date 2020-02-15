//Write a program in C# Sharp to convert a string array to a string

using System;
using System.Linq;
using System.Collections.Generic;

/* The String.join() method connects elements of a specified array or collection members 
   using a specific separator between each element or member (e.g. ", ").
   The Select () method replaces array elements with the String type just in case.*/
namespace LINQ09
{
    class LINQ09
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "cat", "hamster", "dog", "lion" };
            var x = String.Join("' ", array.Select(a => a.ToString()).ToArray());
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
