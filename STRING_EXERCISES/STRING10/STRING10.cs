//Write a C # program to find the largest and lowest values of the three integers.

using System;

//The most important is the Math class method, i.e. Math.Max () and Math.Min () which compare ONLY 2 numbers with each other.

namespace STRING10
{
    class STRING10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write 1st number.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, write 2nd number.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, write 3rd number.");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine("Largest of three is:" + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Lowest of three is:" + Math.Min(a, Math.Min(b, c)));

            Console.ReadKey();
        }
    }
}
