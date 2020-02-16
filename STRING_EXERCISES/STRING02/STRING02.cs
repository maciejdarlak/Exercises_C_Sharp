using System;


namespace STRING02
{
    class STRING02
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 3, -5, 4 };
            int[] secondArray = { 1, 4, -5, -2 };

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] * secondArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
