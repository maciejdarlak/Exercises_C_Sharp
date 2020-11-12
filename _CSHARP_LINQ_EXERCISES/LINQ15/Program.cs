using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ15 //Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>() { 1, 30, 35, 50, 150 };
            var B = A.Select(x => x).Where(x => x > 30 && x < 100);
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
        }
    }
}
