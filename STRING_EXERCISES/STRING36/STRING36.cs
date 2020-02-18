//Write a C # Sharp program to create a new string with the last character added to the front and back of a given string of 1 or more.

using System;

namespace STRING36
{
    class STRING36
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string yourString = Console.ReadLine();

            string lastLetter = yourString.Substring(yourString.Length - 1, 1);
            string finalString = yourString.Length < 1 ? yourString : lastLetter + yourString + lastLetter;

            Console.WriteLine(finalString);

            Console.ReadKey();
        }
    }
}
