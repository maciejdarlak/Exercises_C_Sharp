//Write a C # program to see if "HP" appears in the second position in the string and returns the string without "HP".

using System;

//Unnecessary declaration and initialization ("new") of the array.
//This is done by the ReadLine() method behind the stage.

namespace STRING08
{
    class STRING08
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write a sentence.");
            string a = Console.ReadLine();
            if (a.Substring(1, 2) == "HP")
                Console.WriteLine(a[0] + a.Substring(3));
            else
                Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
