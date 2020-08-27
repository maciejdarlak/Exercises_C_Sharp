//Write a C # Sharp program to check the two given integers, whether any of them is in the range 100..200 inclusive.

using System;

namespace STRING42
{
    class STRING42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Test(numberOne, numberTwo));
            Console.ReadKey();
        }

        public static bool Test(int a, int b)
        {
            int min = 100, max = 200;
            return (a >= min && a <= max) || (b >= min && b <= max) ? true : false;
        }
    }
}
