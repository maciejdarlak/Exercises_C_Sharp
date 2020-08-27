//Write a program in C# Sharp to display the number and frequency of number from giving array.

using System;
using System.Linq;


namespace LINQ4
{
    class LINQ4
    {
        static void Main(string[] args)
        {
            string basic = "apple";

            // OredyBy - sets numbers from the smallest to the largest - I used for order, it is not required here
            // GroupBy - creates sets of the same numbers
            // Select - anonymous type new {} was used (works as a quick grouping of many variables), Count () returns the number of elements in the sequence
            var collection = basic.GroupBy(a => a).Select(a => new { MainKey = a.Key, MainCount = a.Count() });

            foreach (var item in collection)
            {
                Console.WriteLine($"{item.MainKey} { item.MainCount}");
            }
            Console.ReadKey();
        }
    }
}
