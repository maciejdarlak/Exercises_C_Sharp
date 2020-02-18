//Write a C # Sharp program to see which number is closest to 100 from the two given integers. Return 0 if two numbers are equal.

using System;

namespace STRING47
{
    class STRING47
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 1st number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write 2nd number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(test(firstNumber, secondNumber));
            Console.ReadKey();
        }

        public static int test(int a, int b)
        {
            const int n = 100;
            int x = Math.Abs(a - n);
            int y = Math.Abs(b - n);

            return x == y ? 0 : (x < y ? a : b);
        }
    }
}
