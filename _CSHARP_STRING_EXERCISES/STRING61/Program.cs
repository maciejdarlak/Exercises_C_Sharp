using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace STRING61 //How to reverse each word in a given string?
{
    class Program
    {
        static void Main(string[] args)
        {
            StringToChange stringToChange = new StringToChange();

            Console.WriteLine("Write a string please.");
            var str = Console.ReadLine();

            var result = stringToChange.ReversedString(str);
            Console.WriteLine(result);
        }

        public class StringToChange 
        {
            public string[] words;

            public string[] ReversedString(string str) //Split a string into words
            {
                words = str.Split();

                foreach (var i in words)
                {
                    Console.WriteLine("{0}", ReversedWord(i));
                }

                return words;
            }

            public string ReversedWord(string wordToReverse) //Reverse order of letters in a specific word
            {
                char[] reversedArray = wordToReverse.ToCharArray();

                Array.Reverse(reversedArray); /*Intead of:

                for (int i = 0, j = wordToReverse.Length - 1; i < j; i++, j--)
                {
                    reversedArray[i] = wordToReverse[j];
                    reversedArray[j] = wordToReverse[i];
                }
                */

                string reversedString = new String(reversedArray);
                return reversedString.ToString();
            }
        }
    }
}
