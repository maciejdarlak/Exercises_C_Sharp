using System;
using System.ComponentModel;

namespace _CSHARP_INHERITANCE_EXERCISES_05
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            Console.WriteLine($"{c.Name}");
        }

        public class A
        {
            public string Name = "A";
            virtual public void Work(string Name)  //virtual
            {
                Console.WriteLine($"{ Name } works.");
            }
        }

        public class B : A
        {
            public string Name = "B";
            override public void Work(string Name)  //override
            {
                Console.WriteLine($"{ Name } works.");
            }
        }

        public class C : A
        {
            public string Name = "C";
            public void Work(string Name)  //override
            {
                Console.WriteLine($"{ Name } works.");
            }
        }
    }
}
