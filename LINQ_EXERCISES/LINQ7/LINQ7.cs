//Write a program in C# Sharp to Accept the members of a list through the keyboard and display the members more than a specific value.

using System;
using System.Collections.Generic;
using System.Linq;


// Use Parse() to replace string to int
// Use LINQ to select data

namespace LINQ7
{
    class LINQ7
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Write a number");
            int y = int.Parse(Console.ReadLine());

            List<int> list = new List<int> { 0, 1, 2, 56, 32, 23 };

            var newList = list.Select(a => a).OrderBy(a => a).Where(a => a > y).ToList();

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
