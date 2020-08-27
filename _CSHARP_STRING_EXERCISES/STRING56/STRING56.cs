//Napisz program C # Sharp, aby sprawdzić, czy po pierwszym pojawieniu się „a” w danym łańcuchu natychmiast następuje kolejne „a”.

using System;

namespace STRING56
{
    class STRING56
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string input = Console.ReadLine();
            Console.WriteLine("Please write what letter would you like to find.");
            string letter = Console.ReadLine();
            Console.WriteLine(Test(input, letter));
            Console.ReadKey();
        }

        public static bool Test(string input, string letter)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i + 1, 1) == letter)
                    return true;
            }

            return false;
        }
    }
}
