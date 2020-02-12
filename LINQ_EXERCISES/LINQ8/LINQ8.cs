//Write a program in C# Sharp to display the top n-th records

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ8
{
    class LINQ8
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 50 };

            Console.WriteLine("Write a number: ");
            int x = int.Parse(Console.ReadLine());

            var newList = list.Select(a => a).Where(a => a > x).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
