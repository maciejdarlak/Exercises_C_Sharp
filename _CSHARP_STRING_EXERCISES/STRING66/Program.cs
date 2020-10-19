using System;

namespace STRING66 //How to perform Right circular rotation of an array?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            int[] array = new int[] { 0, 1, 2 }; 
            a.RotateRight(array);
        }

        public class A
        {
            int temp;

            public void RotateRight(int[] array) 
            {
                for (int i = 0; i < array.Length -1; i++) //102 120 - changes the position of two consecutive numbers [0] and [1], then another two and [1] and [2].
                {
                    temp = array[0];
                    array[0] = array[i + 1];
                    array[i + 1] = temp;
                }

                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }    
            }
        }
    }
}
