//Write a C # program to find the largest value between the first and last element of an integer array.

using System;

//The value of intArray[0] is replaced by the next largest elements of the array.

namespace STRING21
{
    class STRING21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an array of integers.\n");
            string strArray = Console.ReadLine();
            int[] intArray = Array.ConvertAll(strArray.ToCharArray(), delegate (char s) { return (int)s - 48; });

            var count = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > count)
                    count = intArray[i];
            }

            Console.WriteLine($"\nThe highest value of the Array is {count}.");

            Console.ReadKey();
        }
    }
}
