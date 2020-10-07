using System;

namespace STRING59 //How to reverse a string?
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        internal static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
        }
    }
}

