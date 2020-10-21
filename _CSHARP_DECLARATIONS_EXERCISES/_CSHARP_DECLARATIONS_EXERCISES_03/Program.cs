using System;
using System.Collections.Generic;

namespace _CSHARP_DECLARATIONS_EXERCISES_03 //How to find second largest integer in an array using only one loop?
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumberArray = new int[] { 8, 10, 3, 7, 5 };
            A a = new A();
            var result = a.SecondBiggestNumber(NumberArray);
            Console.WriteLine(result);
        }

        public class A
        {
            public int SecondBiggestNumber(int[] numberArray)
            {
                foreach (var num in numberArray)
                {
                    if (num > 0 && numberArray.Length > 1) //Important condition
                    {
                        Array.Sort(numberArray); //That's the point
                    }
                }

                var result = numberArray[numberArray.Length - 2]; //The second largest number is taken from the ordered array
                return result;
            }
        }
    }
}
