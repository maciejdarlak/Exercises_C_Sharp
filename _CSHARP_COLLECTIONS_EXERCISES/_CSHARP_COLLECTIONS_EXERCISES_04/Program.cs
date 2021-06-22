using System;
using System.Collections.Generic;


/*  Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length, e.g:
    ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
    ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
    ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]  */

namespace _CSHARP_COLLECTIONS_EXERCISES_04
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();            
            var result = a.makeArray(7, 5);

            Console.WriteLine(result[1]);
            
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public class A 
        {
            int num;
            int length;

            int[] arrayResult = new int[length];

            public int[] makeArray(int num, int length)
            {
                

                for (int i = 0; i < length; i++)
                {
                    arrayResult[i] += num;
                }

                return arrayResult;
            }


        }
    }
}
