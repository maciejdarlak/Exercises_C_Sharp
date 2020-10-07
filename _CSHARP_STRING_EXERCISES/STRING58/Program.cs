using System;

namespace STRING58 //How to use the Reverse() method of array class
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = A;

            foreach (var i in A)
            {
                Console.Write(i);
            }

            Console.WriteLine(); //A gap line

            Array.Reverse(B); //That's the point

            foreach (var j in B)
            {
                Console.Write(j);
            }
        }
    }
}
