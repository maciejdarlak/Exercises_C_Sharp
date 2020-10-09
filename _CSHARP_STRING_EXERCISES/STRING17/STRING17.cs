//Napisz tablicę znaków i zsumuj z niej liczby.

using System;
using System.Linq;

//The key is to use (before the loop) the char.GetNumericValue () method to replace string with double.

namespace STRING17
{
    class STRING17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an array of integers.\n");
            string strArray = Console.ReadLine();
            var intArray = strArray.Select(char.GetNumericValue).ToArray();
            int sum = 0;

            foreach (int number in intArray)
            {
                sum += number;
            }

            Console.WriteLine($"\nThe sum is: {sum}");

            Console.ReadKey();
        }
    }
}
