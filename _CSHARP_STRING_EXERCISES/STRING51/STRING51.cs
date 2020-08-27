//Write C # Sharp to check if the two non-negative integers given have the same last digit.

using System;

//The MODULE works best because it gives the remainder of the division (here by 10) which is the last digit.

namespace STRING51
{
    class STRING51
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 1st integer.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write 2nd integer.");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b));
            Console.ReadKey();
        }

        public static bool Test(int a, int b)
        {
            return Math.Abs(a % 10) == Math.Abs(b % 10);
        }
    }
}
