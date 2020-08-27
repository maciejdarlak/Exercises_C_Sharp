//Write a C # Sharp program to check if the two given integers are in the range 40..50 inclusive, or both are in the range 50..60 inclusive.

using System;

namespace STRING48
{
    class STRING48
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

        public static bool Test(int a, int b)
        {
            return ((40 <= a && a <= 50) && (40 <= b && b <= 50)) || ((50 <= a && a <= 60) && (50 <= b && b <= 60));
        }
    }
}
