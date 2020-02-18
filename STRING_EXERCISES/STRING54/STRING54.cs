//Write a C # Sharp program to create a new string that is n (a nonnegative integer) copies 
//of the first 3 characters of the string. If the length of a given string is less than 3, return n copies of the string.

using System;

namespace STRING54
{
    class STRING54
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string input = Console.ReadLine();
            Console.WriteLine("Please write how many copies you would like to have.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Test(input, n));
            Console.ReadKey();
        }

        public static string Test(string input, int n)
        {
            string finalString = String.Empty;

            if (input.Length < 3)
            {
                for (int i = 0; i < n; i++)
                    finalString += input;
            }

            else
            {
                for (int i = 0; i < n; i++)
                    finalString += input.Substring(0, 3);
            }

            return finalString;
        }
    }
}
