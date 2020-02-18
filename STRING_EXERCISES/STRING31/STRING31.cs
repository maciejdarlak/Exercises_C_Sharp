//Write a C # Sharp program to calculate the sum of the two given integers. If these two values are the same, return the triple sum.

using System;

namespace STRING31
{
    class STRING31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 1st number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write 2nd number.");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a != b)
                Console.WriteLine(a + b);
            else
                Console.WriteLine(3 * (a + b));

            Console.ReadKey();
        }
    }
}
