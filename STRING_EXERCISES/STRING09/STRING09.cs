//Write a C # program to get a new string of two characters from the given string. 
//The first and second characters of the string must be "P" and "H", so PHP will be "PH".

using System;

//Substring (0; 2) - substring - starts from [0] (i.e. from the beginning) and contains two consecutive characters.

namespace STRING09
{
    class STRING09
    {
        static void Main(string[] args)
        {
            string firstSentence = "PHP Tutorial";
            string secondSentence = firstSentence.Substring(0, 2);
            Console.WriteLine(secondSentence);
            Console.ReadKey();
        }
    }
}
