using System;
using System.Security.Cryptography.X509Certificates;

namespace _CSHARP_DECLARATIONS_EXERCISES_02 //How to find if a positive integer is a prime number or not?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Write a number pls.");
            string str = Console.ReadLine();
            a.PrimeNumber(str);
            Console.WriteLine();
        }

        public class A
        {
            public void PrimeNumber(string str)
            {
                int num = int.Parse(str);

            }
        }
    }
}
