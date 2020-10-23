using System;
using System.Collections.Immutable;

namespace _CSHARP_DECLARATIONS_EXERCISES_04 //How to find third largest integer in an array using only one loop?
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumberArray = new int[] { 8, 10, 3, 12, 7, 5 };
            A a = new A();
            var result = a.ThirdBiggestNumber(NumberArray);
            Console.WriteLine(result);
        }

        public class A
        {
            public int ThirdBiggestNumber(int[] numberArray)
            {
                foreach (var num in numberArray)
                {
                    if (num > 0 && numberArray.Length > 2)
                    {
                        Array.Sort(numberArray);
                    }                
                }
                return numberArray[numberArray.Length - 3];
            }
        }
    }
}
