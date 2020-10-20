using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _CSHARP_DECLARATIONS_EXERCISES_02 //How to find the sum of digits of a positive integer?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Write a number pls.");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            a.DigitsAmount(num);
            Console.WriteLine();
        }

        public class A
        {
            public void DigitsAmount(int num) //num = 123
            {
                int result = 0;

                while (num > 0)
                {
                    result += num % 10; //3 and leaves 120, 2 and leaves 10, 1 and leaves 0 (loop finish)
                    num /= 10; // num/10 = 12, num/10 = 1,
                }

                Console.WriteLine(result);
            }
        }
    }
}
