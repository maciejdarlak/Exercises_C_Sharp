//Write a C # Sharp program to see if the "yt" string appears at index 1 in that string. If it appears, return the string without "yt", otherwise return the original string.

using System;

namespace STRING45
{
    class STRING45
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string yourString = Console.ReadLine();

            Console.WriteLine(Test(yourString));
            Console.ReadKey();
        }

        public static string Test(string a)
        {
            if (a.Length >= 3)
            {
                return a.Substring(1, 2).ToString().ToLower().Equals("yt") ? a.Remove(1, 2) : a;
            }
            else
                return "More letters motherfucker!";
        }
    }
}
