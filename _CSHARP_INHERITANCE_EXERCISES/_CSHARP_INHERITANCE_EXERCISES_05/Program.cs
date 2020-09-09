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
            C c = new C();
            NoImpementation noImpementation = new NoImpementation();

            b.Work();
        }

        public class A
        {
            virtual public void Work() //Virtual
            {
                Console.WriteLine("A");
            }
        }

        public class B : A
        {
            virtual public void Work() //Override
            {
                Console.WriteLine("B");
            }
        }

        public class C : A
        {
            public void Work() //
            {
                base.Work();
                Console.WriteLine("C");
            }
        }

        public class NoImpementation : A
        {
            public void Work() //NoImpementation - no obscuring
            {
                Console.WriteLine("NoImpementation");
            }
        }
    }
}