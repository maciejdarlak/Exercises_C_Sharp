using System;
using System.Runtime.CompilerServices;

namespace _CSHARP_DELEGATES_EXERCISES_01
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            static int Method1(int X)
            {
                return X * X;
            }

            static int Method2(int X)
            {
                return X / X;
            }          


            A a = new A(Method1);

            Console.WriteLine(a(10));


            a = Method2;

            Console.WriteLine(a(10));

        }

        public delegate int A(int X);
    }
}
    