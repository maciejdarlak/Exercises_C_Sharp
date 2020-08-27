//Write a C # Sharp program to see if the "yt" string appears at index 1 in that string. If it appears, return the string without "yt", otherwise return the original string.

using System;

namespace STRING44
{
    class STRING44
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
                if (a.Substring(1, 2) == "yt")
                {
                    return a.Substring(0, 1) + a.Substring(3, a.Length - 3);
                }
                else
                    return a;
            }
            else
                return "Please write more letters.";
        }
    }
}
