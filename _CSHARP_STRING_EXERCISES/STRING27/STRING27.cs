//Write a C # program to find a pair of adjacent elements that have the highest product of a given array of integers.

using System;

namespace STRING27
{
    class STRING27
    {
        static void Main(string[] args)
        {
            //Number of array elements
            Console.WriteLine("Please write how many numbers would you like to have in your array (there must to be value over 1).\n");
            int itemsNumber = Convert.ToInt32(Console.ReadLine());

            //It takes two to tango product
            if (itemsNumber < 2)
            {
                Console.WriteLine("\nFalse.");
                Console.ReadKey();
            }
            // Since there are at least two ...
            else
            {
                //Array initialization
                int[] array = new int[itemsNumber];

                //Giving value to each element of the array
                for (int i = 0; i < itemsNumber; i++)
                {
                    Console.WriteLine("\nPlease write the value of item.\n");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                //Finding the largest product
                int max = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    max = (array[i] * array[i + 1]) > max ? (array[i] * array[i + 1]) : max;
                }

                Console.WriteLine($"\nAnswer is: {max}");
                Console.ReadKey();
            }
        }
    }
}
