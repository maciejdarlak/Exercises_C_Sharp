//Write a program in C# Sharp to find the uppercase words in a string

using System;
using System.Linq;
using System.Collections.Generic;

//The Split (' ') method splits a string into words
namespace LINQ08
{
    class LINQ08
    {
        static void Main(string[] args)
        {
            string a = "ALICE has a nice CAT";
            var b = a.Split(' ').Where(a => a == a.ToUpper());

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
