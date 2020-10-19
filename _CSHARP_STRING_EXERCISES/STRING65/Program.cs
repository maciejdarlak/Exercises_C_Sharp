using System;
using System.Text;

namespace STRING65
{
    class Program //How to perform Left circular rotation of an array?
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2 };
            A a = new A();
            a.RotateLeft(array);
            Console.WriteLine();
        }

        public class A
        {
            public void RotateLeft(int[] array)
            {
                int temp;

                for (int i = array.Length - 1; i > 0; i--)
                {
                    temp = array[array.Length - 1]; // X = A
                    array[array.Length - 1] = array[i - 1]; // A = A-1
                    array[i - 1] = temp; // A-1 = X
                }

                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
