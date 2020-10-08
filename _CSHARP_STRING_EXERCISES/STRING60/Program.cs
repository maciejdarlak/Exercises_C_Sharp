using System;

namespace STRING60 //How to find if the given string is a palindrome or not?
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrom palindrom = new Palindrom();

            Console.WriteLine("Write a string please.\n");
            palindrom.str = Console.ReadLine();
            Console.WriteLine("\n");

            if (palindrom.IsPalindrom() is true)
                Console.WriteLine("Palindrom.");
            else
                Console.WriteLine("Not palindrom.");
        }

        public class Palindrom
        {
            public string str;

            public bool IsPalindrom()
            {
                if (String.IsNullOrEmpty(str)) //Elimination of empty strings
                    return false;

                str = str.Replace(" ", "").ToLower(); //Removing spaces and convert capital letters to lower case

                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - 1])
                        return false;
                }
                return true;              
            }
        }
    }
}
