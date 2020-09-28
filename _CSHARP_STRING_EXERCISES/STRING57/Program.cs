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
            a.ReverseString("123456789");
            Console.WriteLine();
        }

        public class A
        {
            public void ReverseString(string str)
            {
                char[] ArrayString = str.ToCharArray();

                for (int i = 0, j = str.Length - 1; ; i++, j--)
                {
                    ArrayString[i] = str[j];
                    ArrayString[j] = str[i];
                }
                Console.WriteLine(ArrayString);
            }
        }
    }
}


















