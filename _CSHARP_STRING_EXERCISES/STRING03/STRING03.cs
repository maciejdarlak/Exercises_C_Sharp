/*Write a C # program to create a new string of four copies, taking the last four characters of the given string. 
 * If the length of a given string is less than 4, return the original.*/

using System;

/*  Substring () - a method that takes a substring from a chain.
    Eg.
    String a = "hamster";
    a. Substring (5) // returns "ter" (from the 5th character)
    a.Substring (length - 1) // returns "r" (all characters length - 1)
    a. Substring (2; 3) returns "ams" (from the 2nd character returns the next 3 characters)*/

namespace STRING03
{
    class STRING03
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();
            int length = input.Length;

            if (length <= 4)
                Console.WriteLine(input);
            else
                Console.WriteLine(input.Substring(length - 4) + input.Substring(length - 4) + input.Substring(length - 4) + input.Substring(length - 4));
            Console.ReadKey();
        }
    }
}
