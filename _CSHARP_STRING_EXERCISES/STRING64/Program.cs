using System;
using System.Text;

namespace STRING64 //How to find all possible substring of a given string?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Pls write a string.");
            string str = Console.ReadLine();
            a.AllSubstrings(str);
            Console.WriteLine();
        }

        public class A
        {
            public void AllSubstrings(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    StringBuilder subString = new StringBuilder(str.Length - i); //Instead "dog" is "og" (amount without 1st character)

                    for (int j = i; j < str.Length; j++)
                    {
                        subString.Append(str[j]);
                        Console.Write(subString + " ");
                    }
                }
            }
        }
    }
}
