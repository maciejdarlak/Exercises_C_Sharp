//Write a program in C# Sharp to display numbers, multiplication of number with frequency and frequency of a number of giving array.

using System;
using System.Linq;

namespace LINQ5
{
    class LINQ5
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var repeatNumber = array.GroupBy(a => a);


            foreach (var item in repeatNumber)
            {
                Console.WriteLine($"{ item.Key } { item.Sum() } { item.Count() }");
            }
            Console.ReadKey();
        }
    }
}
