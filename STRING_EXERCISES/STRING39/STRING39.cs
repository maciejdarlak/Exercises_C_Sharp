//Write C # Sharp to see if the string begins with "C #" or not.

using System;

namespace STRING39
{
    class STRING39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a string with more than 2 letters.");
            string yourString = Console.ReadLine();

            if (yourString.Length > 2)
            {
                string twoFirstLetters = yourString.Substring(0, 2);

                if (twoFirstLetters == "C#")
                    Console.WriteLine("True.");
                else
                    Console.WriteLine("False.");
            }
            else
                Console.WriteLine("Please write more letters.");

            Console.ReadKey();
        }
    }
}
