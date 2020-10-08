using System;

namespace STRING60 //How to find if the given string is a palindrome or not?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            Console.WriteLine("Write a word pls.\n");
            a.str = Console.ReadLine();
            Console.WriteLine("\n");

            if (a.ReverseStr1() == a.ReverseStr2())
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome.");
            }
        }

        public class A
        {
            public string str;

            public string ReverseStr1()
            {               
                char[] charArray = str.ToCharArray();

                for (int i = 0, j = str.Length - 1; i < j; i++, j--) // E.g. 123 --> 321, 121 --> 121
                {
                    charArray[i] = str[j];
                    charArray[j] = str[i];
                }

                string reversedString = new string(charArray);
                return reversedString;
            }

            public string ReverseStr2()
            {
                char[] charArray = str.ToCharArray();

                for (int i = 0, j = str.Length - 1; i < j; i++, j--) //Just one line e.g. 123 --> 121, 121 --> 121
                {
                    charArray[i] = str[j]; 
                }

                string reversedString = new string(charArray);
                return reversedString;
            }
        }
    }
}
