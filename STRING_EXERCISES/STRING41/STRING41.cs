//Write a C # Sharp program to check if one of the temperatures given is less than 0 and the other is greater than 100.

using System;

namespace STRING41
{
    class STRING41
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
            int min = 0, max = 100;
            return a < min && b > max || b < min && a > max ? true : false;
        }
    }
}
