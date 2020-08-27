//Write a C # program to count the number of occurrences of a specific number in a given array of integers.

using System;

//Pass all string characters (which is an array of characters) through foreach.
//The single character is of type char, so you have to compare it with the same type in the loop, hence the explicit conversion for searchedNumber.

namespace STRING16
{
    class STRING16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string of numbers.");
            string input = Console.ReadLine();
            Console.WriteLine("\nPlease write a number what you look for in a previous string");
            int searchedNumber = Convert.ToChar(Console.ReadLine());

            int result = 0;

            foreach (char number in input)
            {
                if (number == searchedNumber)
                    result++;
            }

            Console.WriteLine($"\nResult is {result}");
            Console.ReadKey();
        }
    }
}
