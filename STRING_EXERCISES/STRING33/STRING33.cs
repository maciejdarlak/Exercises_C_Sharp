//Write C # Sharp to check two given integers and return true if one of them is 30 or if their sum is 30.

using System;

//Operator || can be used more than 2 times.

namespace STRING33
{
    class STRING33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 30 || b == 30 || a + b == 30)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
