//Write an array of characters and check that the first and last characters are equal.

using System;

namespace STRING18
{
    class STRING18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an array of integers.\n");
            string strArray = Console.ReadLine();
            var intArray = strArray.Select(char.GetNumericValue).ToArray();

            if (intArray.Length > 1 && intArray[0] == intArray[intArray.Length - 1])
                Console.WriteLine("\nTrue.");
            else
                Console.WriteLine("\nFalse.");

            Console.ReadKey();
        }
    }
}
