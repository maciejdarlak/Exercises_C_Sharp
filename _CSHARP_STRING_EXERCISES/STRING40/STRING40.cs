//Write C # Sharp to see if the string begins with "C #" or not.

using System;

namespace STRING40
{
    class STRING40
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string with more than 2 letters.");
            string yourString = Console.ReadLine();
            Console.WriteLine(Test(yourString, "C#"));
            Console.ReadKey();
        }

        public static bool Test(string yourString, string startwith = "C#")
        {
            return yourString.ToLower().StartsWith(startwith.ToLower()) ? true : false;
        }
    }
}
