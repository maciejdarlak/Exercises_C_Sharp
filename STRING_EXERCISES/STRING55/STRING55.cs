//Write a C # Sharp program to count the string "aa" in the given string and assuming that "aaa" contains two "aa".

using System;

namespace STRING55
{
    class STRING55
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string input = Console.ReadLine();
            Console.WriteLine("Please write what string would you like to find.");
            string fragment = Console.ReadLine();
            Console.WriteLine(Test(input, fragment));
            Console.ReadKey();
        }

        public static int Test(string input, string fragment)
        {
            int finalCount = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i, 2) == fragment)
                {
                    finalCount++;
                }
            }

            return finalCount;
        }
    }
}
