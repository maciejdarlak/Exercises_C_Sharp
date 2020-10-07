using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace STRING59 //How to reverse a string?
{
    class Program //How to reverse a string?
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.ReverseStr("12345"));
        }

        public class A
        {
            public string ReverseStr(string _str)
            {
                char[] charArray = _str.ToCharArray();

                for (int i = 0, j = _str.Length - 1; i < j; i++, j--) //Only 2 loops then starts to be i >= j
                {
                    charArray[i] = _str[j]; 
                    charArray[j] = _str[i];
                }

                string reversedstring = new string(charArray);
                return reversedstring.ToString();
            }
        }
    }
}

