//Write a C # program to see if the string starts with a specific word.

using System;

/*Robimy ze zdania tablcę słów.
Porównujemy[0] z danym słowem.
Zmieniamy wartość z logcznej na string.*/

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
