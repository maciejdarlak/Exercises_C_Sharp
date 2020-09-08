using System;
using System.ComponentModel;

namespace _CSHARP_INHERITANCE_EXERCISES_05
{
    class Program  //Virtual methods
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            Console.WriteLine($"{ b.Work(b.Name) }");
        }

        public class A
        {
            public string Name = "A";
            virtual public string Work(string Name)  //Virtual
            {
                return ($"{ Name }");
            }
        }

        public class B : A
        {
            public string Name = "B";
            override public string Work(string Name)  //Override
            {
                return ($"{ Name }");
            }
        }
    }
}
