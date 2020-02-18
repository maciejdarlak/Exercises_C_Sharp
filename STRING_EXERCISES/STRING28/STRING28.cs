//Write a program that will answer the question how many elements are missing in a given collection, e.g. {2; 5} two are missing, i.e. 3 and 4. (answer 5 -2 - (1) = 2).

using System;

namespace STRING28
{
    class STRING28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write how many items would you like to have in the array.");
            int itemsNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[itemsNumber];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please write an item.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //It's important to sort the collection, Main is a method so everything goes one by one from top to bottom
            Array.Sort(array);
            int ctr = 0;

            //The difference between the SORTED items (not including the extreme says how many numbers have been left out)
            for (int i = 0; i < array.Length - 1; i++)
            {
                ctr += array[i + 1] - array[i] - 1;
            }

            Console.WriteLine(ctr);
            Console.ReadLine();
        }
    }
}
