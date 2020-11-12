using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> A = new List<string>() { "learn", "current", "deal" };
            var B = A.Select(x => x.Contains("ea") ? x.Replace("ea", "XXX") : x);
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
        }
    }
}

