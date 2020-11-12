using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ18 //Write a query that returns list of numbers and their squares only if square is greater than 20
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> A = new List<int>() { 3, 10, 20 };
            var B = A.Where(x => x * x > 20);
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
        }
    }
}
