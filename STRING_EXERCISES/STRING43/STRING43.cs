//Write a C # Sharp program to check if the three given integers are in the range 20..50 inclusive. Return true if 1 or more of them are in the mentioned range, otherwise false.

using System;

namespace STRING43
{
    class STRING43
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a first number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a third number.");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(numberOne, numberTwo, numberThree));
            Console.ReadKey();
        }

        public static bool Test(int a, int b, int c)
        {
            int min = 20, max = 50;
            return (a >= min && a <= max) || (b >= min && b <= max) || (c >= min && c <= max) ? true : false;
        }
    }
}
