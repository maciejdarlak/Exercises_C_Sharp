//Write a C # program to create a new string of every other character (odd position) from the first position of the given string.

using System;

//For string modyfiedInput = ""; we must assign anything because the default string value is "null".

namespace STRING15
{
    class STRING15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string.");
            string input = Console.ReadLine();
            string modyfiedInput = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    modyfiedInput += input[i];
            }

            Console.WriteLine(modyfiedInput);

            Console.ReadKey();
        }
    }
}
