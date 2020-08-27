// Write a C # program to create a new string in which the first 4 characters will be in lowercase.
// If the string is less than 4 characters, complete the string in uppercase.

using System;

//Create a variable that reduces the first 4 letters. Then insert it using the Replace() method.

namespace STRING13
{
    class STRING13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string.");
            string input = Console.ReadLine();
            string fourSmallLeters = input.Substring(0, 4);

            if (input.Length < 4)
                Console.WriteLine(input.ToUpper());
            else
                Console.WriteLine(input.Replace(fourSmallLeters, fourSmallLeters.ToLower()));

            Console.ReadKey();
        }
    }
}
