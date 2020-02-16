//Write a C# Sharp program to compare the current string instance with another string. 

using System;

//You only need to check if this is true using the logical operator "||" (answer "true" or "false").

namespace STRING04
{
    class STRING04
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            int input = Convert.ToInt32(Console.Read());

            if (input > 0)
                Console.WriteLine(input % 3 == 0 || input % 7 == 0);
            Console.ReadKey();
        }
    }
}
