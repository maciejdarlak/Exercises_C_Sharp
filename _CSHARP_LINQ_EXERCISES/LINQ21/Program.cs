using System;
using System.Collections.Generic;
using System.Linq;


/*Replace substring
Write a query that replaces 'ea' substring with astersik (*) in given list of words.
Expected input and output
"learn", "current", "deal" →  "l*rn", "current", "d*l"*/


namespace LINQ21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = new List<string>() { "learn", "current", "deal", "l*rn", "current", "d*l" };
            var secondList = firstList.Select(x => x.Contains("ea") ? x.Replace("ea", "*" ) : x);

            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
