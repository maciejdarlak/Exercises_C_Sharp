//Write a C # program to check if the array contains an odd number.

using System;

namespace STRING23
{
    class STRING23
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 7, 8, 6 };

            foreach (var i in nums)
            {
                if (i % 2 != 0)
                    Console.WriteLine(true);
            }

            Console.ReadKey();
        }
    }
}
