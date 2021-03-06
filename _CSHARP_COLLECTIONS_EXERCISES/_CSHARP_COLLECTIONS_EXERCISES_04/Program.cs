﻿using System;
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
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public class A 
        {
            public int[] makeArray(int num, int length) 
            {
                int[] arrayResult = new int[length]; // An array is created.

                arrayResult[0] = num;

                for (int i = 1; i < length; i++)
                {
                    arrayResult[i] += arrayResult[i - 1] + num;
                }

                return arrayResult; // This array is a result.
            }
        }
    }
}
