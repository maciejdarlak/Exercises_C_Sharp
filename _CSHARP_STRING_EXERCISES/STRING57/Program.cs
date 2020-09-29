using System;
using System.Globalization;
using System.Linq;

namespace STRING57 //How to reverse a string?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.ReverseString("123");
            Console.WriteLine();
        }

        public class A
        {
            public void ReverseString(string str)
            {
                char[] str2 = str.ToCharArray(); //Returns char array

                for (int i = 0, j = str.Length - 1; i<j; i++, j--) //i < j cause to start loop
                {
                    str2[i] = str[j]; //Range: 1 
                    str2[j] = str[i]; //Range: 2 -3 
                }
                Console.WriteLine(str2);
            }
        }
    }
}





























