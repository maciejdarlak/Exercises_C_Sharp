using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ20 //Write a query that returns only uppercase words from string.
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "DIVINE, beat, Cat";
            var bigLetterWords = A.Split(' ').Where(x => string.Equals(x, x.ToUpper()));
            foreach (var item in bigLetterWords)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
