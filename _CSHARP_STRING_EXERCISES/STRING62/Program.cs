using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace STRING62 //How to count the occurrence of each character in a string?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            Console.WriteLine("Write a string please.");
            var str = Console.ReadLine();

            a.Countcharacter(str);
        }

        public class A
        {
            public void Countcharacter(string str)
            {
                Dictionary<char, int> characterCount = new Dictionary<char, int>();

                foreach (var character in str)
                {
                    if (character != ' ') //Eliminate spaces
                    {
                        if (!characterCount.ContainsKey(character)) //If doesn't contains this sign...
                        {
                            characterCount.Add(character, 1); //...is created a new key in Dictionary
                        }
                        else
                        {
                            characterCount[character]++; //If contains this sign is added a value
                        }
                    }
                }

                foreach (var character in characterCount)
                {
                    Console.WriteLine("{0} - {1}", character.Key, character.Value);
                }
            }
        }
    }
}
                                                                                                        