using System;

namespace _CSHARP_EXCEPTIONS_EXERCISES_01  //Divide by zero exception
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(1, 0);  //Result: 1 / 0
            Console.WriteLine(a.result);
        }

        public class A
        {
            public int result = 0;
            public A (int x, int y)
            {
                try
                {
                    result = x / y;
                }
                catch (DivideByZeroException Ex)
                {
                    Console.WriteLine("Exception: {0}" , Ex);
                }
                
            }
        }
    }
}
