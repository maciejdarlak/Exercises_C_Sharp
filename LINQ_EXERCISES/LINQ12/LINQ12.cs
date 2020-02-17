//Write a program in C# Sharp to find the strings for a specific minimum length. 

using System;
using System.Linq;
using System.Collections.Generic;


namespace LINQ12
{
    class LINQ12
    {
        static void Main(string[] args)
        {
            //List creating
            Console.WriteLine("Write a number of list items.");
            int arrayNumber = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < arrayNumber; i++)
            {
                Console.WriteLine("Write a string.");
                string str = Console.ReadLine().ToString();
                list.Add(str);
            }

            //Enter the maximum number of characters
            Console.WriteLine("Write a minimal letters number");
            int minLettersArray = int.Parse(Console.ReadLine());

            //New list creating
            var finalStrings = list.Select(a => a).Where(a => a.Length >= minLettersArray).ToList();

            foreach (var item in finalStrings)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
