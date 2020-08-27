//Write a program in C# Program to Count File Extensions and Group it using LINQ.

using System;
using System.Linq;
using System.Collections.Generic;

//Grouped array elements, then (Count ()) element of each group (Key).
namespace LINQ11
{
    class LINQ11
    {
        static void Main(string[] args)
        {
            string[] array = { ".xml", ".pdf", ".epub", ".mp3", ".flac", ".mp3", ".xml" };
            var array2 = array.GroupBy(a => a).Select(a => new { Name = a.Key, MainCount = a.Count() }).ToArray();

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
