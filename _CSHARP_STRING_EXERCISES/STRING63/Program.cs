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
            public string result = string.Empty; //A new one

            public void RemovedDuplicate()
            {
                foreach (var character in str) //Character is automatically char type
                {
                    if (character != ' ') //Gap elemination
                    {
                        if (!result.Contains(character))
                        {
                            result += character;
                        }
                    }
                }

                foreach (var character in result)
                {
                    Console.Write("{0}", character) ;
                }
            }
        }
    }
}
