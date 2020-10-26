using System;
using System.Linq;


namespace _CSHARP_COLLECTIONS_EXERCISES_03 //How to merge two arrays to a one array?
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new[] { 1, 2 };
            int[] y = new[] { 3, 4 };
            A a = new A();
            var result = a.SumArray(x, y);
            Console.WriteLine(result);
        }

        public class A
        {
            public int[] SumArray(int[] x, int[] y)
            {
                x.Concat(y).ToArray();
                return x;
            }
        }
    }
}