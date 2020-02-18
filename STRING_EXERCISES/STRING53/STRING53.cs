//Write C # Sharp to create a new string, x n (a non-negative integer).

using System;

//It's important to use String.Empty as the zero string at the beginning

namespace STRING53
{
    class STRING53
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

            for (int i = 0; i < n; i++)
                finalString += input;

            return finalString;
        }
    }
}
