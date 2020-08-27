//Write a C # program to see if the string is a palindome or not.

using System;

namespace STRING26
{
    class STRING26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the string.");
            string inputString = Console.ReadLine();

            //First, check whether an empty string or null value was not passed. If so, we return false.
            if (string.IsNullOrEmpty(inputString))
                Console.WriteLine("False.");

            //Get rid of spaces and change everything to lowercase.
            inputString = inputString.Replace(" ", "").ToLower();

            int doubts = 0;

            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - i - 1])
                    doubts += 1;
            }

            if (doubts > 0)
                Console.WriteLine("False");
            if (doubts == 0)
                Console.WriteLine("True");

            Console.ReadKey();
        }
    }
}
