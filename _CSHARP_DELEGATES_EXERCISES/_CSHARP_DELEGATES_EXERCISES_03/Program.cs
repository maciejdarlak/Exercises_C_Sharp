using System;

namespace _CSHARP_DELEGATES_EXERCISES_03
{
   

    class Program
    {
        static void Main(string[] args)
        {           
            A a = new A();

            Description description = new Description(a.Method1);

            description += a.Method2;

            string result1 = a.Method1("It ");
            string result2 = a.Method2("works");

            Console.WriteLine(description(result1, result2));
        }

        public delegate string Description(string value);

        public class A
        {          
            public string Method1(string x)
            {
                return x;
            }

            public string Method2(string y)
            {
                return y;
            }
        }
    }
}
