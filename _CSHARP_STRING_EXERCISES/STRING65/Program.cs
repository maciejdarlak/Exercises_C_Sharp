using System;
using System.Text;

namespace STRING65
{
    class Program //How to perform Left circular rotation of an array?
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {  1, 2, 3 };
            A a = new A();
            a.RotateLeft(array);
            Console.WriteLine();
        }

        public class A
        {
            public void RotateLeft(int[] array)
            {
                int size = array.Length;
                int temp;

                for (int j = size - 1; j > 0; j--)
                {
                    temp = array[size - 1];
                    array[array.Length - 1] = array[j - 1];
                    array[j - 1] = temp;
                }

                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
