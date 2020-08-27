//Write a C # Sharp program to find a larger value of two positive integers that are in the range 20..30 inclusive, or return 0 if none of them are in this range.

using System;

namespace STRING49
{
    class STRING49
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 1st number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write 2nd number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(firstNumber, secondNumber));
            Console.ReadKey();
        }

        public static int Test(int a, int b)
        {
            if ((20 <= a && a <= 30) && (20 <= b && b <= 30))
            {
                return a > b ? a : b;
            }
            else
                return 0;
        }
    }
}
