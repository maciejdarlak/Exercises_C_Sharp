using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ17 //Write a query that returns words starting with letter 'b' and ending with letter 'a'.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> A = new List<string>() { "Paris", "Barcelona", "Rome" };
            var B = A.Where(x => x.StartsWith("B")).Where(x => x.EndsWith("a"));
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
        }
    }
}
