//Write a C # program to get the age of the year.

using System;

namespace STRING24
{
    class STRING24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an year.\n");
            int year = Convert.ToInt32(Console.ReadLine());
            int centaury = year / 100 + ((year % 100 == 0) ? 0 : 1);
            Console.WriteLine($"\nThe centaury is: {centaury}.");
            Console.ReadKey();
        }
    }
}
