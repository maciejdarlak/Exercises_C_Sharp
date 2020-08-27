//Napisz program C #, aby obrócić elementy tablicy liczb całkowitych w którymś kierunku.

using System;

/*First, the method as in the exercise above - changing string to int (note the values are as for char (the ASC || table is therefore "- 48").
Finally, the Join method(string, string[]) which joins all elements of the string array using the specified separator between elements*/

namespace STRING20
{
    class STRING20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write an array of integers.\n");
            string strArray = Console.ReadLine();
            int[] intArray = Array.ConvertAll(strArray.ToCharArray(), delegate (char s) { return (int)s - 48; });

            int temp = intArray[0];

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }

            intArray[intArray.Length - 1] = temp;

            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", intArray));
            Console.ReadKey();
        }
    }
}
