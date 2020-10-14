using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace STRING63 //How to remove duplicate characters from a string?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Pls, write a string.");
            a.str = Console.ReadLine();
            a.RemovedDuplicate();
            Console.WriteLine();
        }

        public class A
        {
            public string str;
            public List<char> singleCharactersList = new List<char>();

            public void RemovedDuplicate()
            {
                char[] charactersArray = str.ToCharArray();

                foreach (var character in charactersArray)
                {
                    if (character != ' ') 
                    {
                        if (!singleCharactersList.Contains(character))
                        {
                            singleCharactersList.Add(character);
                        }
                    }
                }

                foreach (var character in singleCharactersList)
                {
                    Console.Write("{0}", character) ;
                }
            }
        }
    }
}
