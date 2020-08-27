//Write a C # Sharp program to check if the positive number is a multiple of 3 or a multiple of 7.

using System;

namespace STRING37
{
    class STRING38
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(test(number, 3));
            Console.WriteLine(test(number, 7));

            Console.ReadKey();
        }

        public static bool test(int number, int factor)
        {
            return number % factor == 0;
        }
    }
}
