//Write C # Sharp to remove a character from a given position in a given string. The position will be in the range of 0 ... string length is 1 inclusive.

using System;

namespace STRING35
{
    class STRING35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string.");
            string input = Console.ReadLine();
            Console.WriteLine("Please write a position to remove.");
            int removedPosition = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input.Remove(removedPosition, 1));
            Console.ReadKey();
        }
    }
}
