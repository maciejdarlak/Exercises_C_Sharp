//Write a program in C# Sharp to find the number of an array and the square of each number. 

using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ3
{
    class LINQ3
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2, 5 };

            // OredyBy - sets numbers from the smallest to the largest - I used for order, it is not required here
            // GroupBy - creates sets of the same numbers
            // Select - anonymous type new {} was used (works as a quick grouping of many variables), Count () returns the number of elements in the sequence
            var newList = list.OrderBy(a => a).GroupBy(a => a).Select(a => new { MainKey = a.Key, MainCount = a.Count() });

            foreach (var item in newList)
            {
                Console.WriteLine($"{item.MainKey} {item.MainCount}");
            }
            Console.ReadKey();
        }
    }
}
