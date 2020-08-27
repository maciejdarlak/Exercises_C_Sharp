//Write a C # program to sort the integers in ascending order without moving the given number (from this table).

using System;
using System.Linq;

namespace STRING29
{
    class STRING29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number to ignore");
            int ignoreNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please write how many inputs would you like to have in the array.");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[inputNumber];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please write the value.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Below is an array with the ignoreNumber value. The ToArray () method copies array elements to a new array.
            int[] array2 = array.Where(x => x != ignoreNumber).OrderBy(x => x).ToArray();

            //The final table below - contains all values but arranged.
            int ctr = 0;
            int[] finalArray = array.Select(x => x >= 0 ? array2[ctr++] : ignoreNumber).ToArray();

            foreach (var item in finalArray)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
