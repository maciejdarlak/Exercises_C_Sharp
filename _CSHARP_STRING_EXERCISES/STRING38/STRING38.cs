//Write a C # Sharp program to create a new string containing the first 3 characters of the string 
//and return a string with 3 characters added both front and back. If the given string length is less than 3, use the characters that are there.

using System;

namespace STRING38
{
    class STRING38
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string yourString = Console.ReadLine();

            if (yourString.Length > 3)
            {
                string lastThreeLetters = yourString.Substring(yourString.Length - 3, 3);
                string finalString = lastThreeLetters + yourString + lastThreeLetters;
                Console.WriteLine(finalString);
            }
            else
                Console.WriteLine(yourString);

            Console.ReadKey();
        }
    }
}
