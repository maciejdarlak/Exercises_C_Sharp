//Write a C # program to check the two numbers given, where one is less than 100 and the other is greater than 200.

using System;

/* It's important to explicitly cast to Int32.
   ReadLine() reads the entire line, Read () a single word.*/

namespace STRING06
{
    class STRING06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a first number (< 100).");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a second number (> 200).");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstNumber < 100 && secondnumber > 200);
            Console.ReadKey();
        }
    }
}
