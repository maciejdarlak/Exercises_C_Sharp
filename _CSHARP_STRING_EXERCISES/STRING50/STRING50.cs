//Write a C # Sharp program to check if the string contains 2 to 4 characters "z".

using System;

namespace STRING50
{
    class STRING50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a character.");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please write a string.");
            string input = Console.ReadLine();

            Console.WriteLine(Test(character, input));
            Console.ReadKey();
        }

        public static bool Test(char character, string input)
        {
            int howManyTimes = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                    howManyTimes++;
            }

            if (howManyTimes >= 2 && howManyTimes <= 4)
                return true;
            else
                return false;
        }
    }
}
