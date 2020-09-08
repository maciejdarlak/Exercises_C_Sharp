using System;
using System.ComponentModel;

namespace _CSHARP_INHERITANCE__EXERCISES_05
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine($"{a.Name}");
        }

        public class A
        {
            public string Name;
            virtual public void Work(string Name)
            {
                Console.WriteLine($"{ Name } works.");
            }
        }
    }
}
