//Write a C # program to check if the integer (of the two integers given) is in the range from -10 to 10.

using System;

/*The Console.ReadLine method always reads input from the user as a string. To get an integer value from a user, 
 * this string must be converted to an integer. Convert.ToInt32 does this.*/

namespace STRING07
{
    class STRING07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a first integer.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write a second integer.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((-10 <= a && 10 >= a) || (-10 <= b && 10 >= b));
            Console.ReadKey();
        }
    }
}
