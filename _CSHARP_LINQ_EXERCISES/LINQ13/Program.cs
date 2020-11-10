using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ13 //Write a query that returns top 5 numbers from the list of integers in descending order.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };
            var fiveNumbers = A.OrderByDescending(x => x).Take(5);

            foreach (var item in fiveNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
