using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ16
{
    class Program //Write a query that returns words at least 5 characters long and make them uppercase.
    {
        static void Main(string[] args)
        {
            List<string> A = new List<string>() { "cat", "tiger" };
            var B = A.Where(x => x.Count() >= 5).Select(x => x.ToUpper());
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
        }
    }
}
