//Write C # Sharp to convert the last 3 characters of the string to uppercase. If the length of the string is less than 3, then all uppercase letters must be entered.

using System;

namespace STRING52
{
    class STRING52
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string input = Console.ReadLine();

            Console.WriteLine(Test(input));
            Console.ReadKey();
        }

        public static string Test(string input)
        {
            if (input.Length < 3)
                return input.ToUpper();
            else
                return input.Substring(0, input.Length - 3) + input.Substring(input.Length - 3, 3).ToUpper();
        }
    }
}
