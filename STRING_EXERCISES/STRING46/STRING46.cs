//Find the largest value among x numbers.

using System;

namespace STRING46
{
    class STRING46
    {
        static void Main(string[] args)
        {
            //Compare the number of numbers
            Console.WriteLine("Please write an array length.");
            int arrayNumber = Convert.ToInt32(Console.ReadLine());

            //An array with the number of numbers to compare
            int[] array = new int[arrayNumber];

            //Giving value to elements of the array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please write a number.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Finding the largest number among the elements of an array
            int biggestNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestNumber)
                    biggestNumber = array[i];
            }

            Console.WriteLine($"The biggest number is {biggestNumber}.");
            Console.ReadKey();
        }
    }
}
