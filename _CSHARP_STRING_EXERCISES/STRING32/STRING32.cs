//Write C # Sharp to get the absolute difference between n and 51. If n is greater than 51, triple the absolute difference.

using System;

namespace STRING32
{
    class STRING32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number.");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 51)
                Console.WriteLine(Math.Abs(51 - n));
            else
                Console.WriteLine(Math.Abs(3 * (51 - n)));

            Console.ReadKey();
        }
    }
}
