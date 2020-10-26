//Write a C # program to see if the string starts with a specific word.

using System;

/* String is changed to an array of words.
[0] is compared to the given word.
The value is changed from logical to string. */

namespace STRING05
{
    class STRING05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Please write a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split();
            bool isSame = word == words[0] ? true : false;

            Console.WriteLine(isSame.ToString());
            Console.ReadKey();
        }
    }
}
