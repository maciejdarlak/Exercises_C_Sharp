//Write C # Sharp to check the given integer and return true if it is between 10 and 100 or 200.

using System;

namespace STRING34
{
    class STRING34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 10 & a <= 100 || a == 200)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
