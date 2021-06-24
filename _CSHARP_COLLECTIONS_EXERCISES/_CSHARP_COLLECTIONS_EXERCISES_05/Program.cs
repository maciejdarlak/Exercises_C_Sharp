/*
    Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.
    Examples
    SumSmallest([19, 5, 42, 2, 77]) ➞ 7
    SumSmallest([10, 343445353, 3453445, 3453545353453]) ➞ 3453455
    SumSmallest([2, 9, 6, -1]) ➞ 8
    SumSmallest([879, 953, 694, -847, 342, 221, -91, -723, 791, -587]) ➞ 563
    SumSmallest([3683, 2902, 3951, -475, 1617, -2385]) ➞ 4519
*/


using System;
using System.Linq;


namespace _CSHARP_COLLECTIONS_EXERCISES_05
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueTimes trueTimes = new TrueTimes();
            int[] array1 = new int[] { 19, 5, 42, 2, 77 };
            var finalResult = trueTimes.SumSmallest(array1);
            Console.WriteLine(finalResult);
        }

        public class TrueTimes
        {
            public int SumSmallest(int[] array1)
            {
                var array2 = array1.Select(x => x).OrderBy(x => x).ToArray();
                var result = array2[0] + array2[1];
                return result;
            }
        }
    }
}
