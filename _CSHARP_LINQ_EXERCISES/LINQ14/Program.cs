using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ14 //Write a query that returns letters and their frequencies in the string.
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word = "inseption";
            var letters = word.GroupBy(x => x);

            foreach (var x in letters)
            {
                Console.Write($"Letter {x.Key} occurs {x.Count()} time(s), ");
            }
        }
    }
}


