//Write two int tables and check that the first and last tables are equal.

using System;

/*The key is the Aray.ConvertAll () method - string converts to an array of characters (char) 
  and delegates as methods references in this case point to the method of converting each char to int.
You can also do it by loop:
for (int i = 0; i<str1.length; ++ i)
{
  strArray1[i] = (int) str1[i];
} */

namespace STRING19
{
    class STRING19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write 1st array of integers.\n");
            string str1 = Console.ReadLine();
            int[] strArray1 = Array.ConvertAll(str1.ToCharArray(), delegate (char s) { return (int)s; });

            Console.WriteLine("\nPlease write 2nd array of integers.\n");
            string str2 = Console.ReadLine();
            int[] strArray2 = Array.ConvertAll(str2.ToCharArray(), delegate (char s) { return (int)s; });

            if (strArray1.Length > 1 && strArray2.Length > 1)
            {
                if (strArray1[0] == strArray2[0] && strArray1[strArray1.Length - 1] == strArray2[strArray2.Length - 1])
                    Console.WriteLine("\nThe first element or the last element of the two arrays ARE equal.");
                else
                    Console.WriteLine("\nThe first element or the last element of the two arrays ARE NOT equal.");
            }
            else
            {
                Console.WriteLine("\nFalse");
            }

            Console.ReadKey();
        }
    }
}
