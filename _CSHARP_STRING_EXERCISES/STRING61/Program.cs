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

            stringToChange.ReversedString(str);
            Console.WriteLine(stringToChange.words);
        }

        public class StringToChange
        {
            public string[] words;

            public void ReversedString(string str)
            {
                words = str.Split();

                foreach (var i in words)
                {                   
                    Console.WriteLine( ("{0}", i.Reverse()));
                }
            }

            public string ReversedWord(string wordToReverse)
            {
                char[] reversedArray = wordToReverse.ToCharArray();

                for (int i = 0, j = wordToReverse.Length; i < j; i++, j--)
                {
                    reversedArray[i] = wordToReverse[j];
                    reversedArray[j] = wordToReverse[i];
                }

                string reversedString = new String(reversedArray);
                return reversedString.ToString();
            }
        }
    }
}
