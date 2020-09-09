using System;

namespace _CSHARP_CLASSES_EXERCISES_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }




        class Bar
        {
            public Bar(Foo obj)
            {
            }
        }

        class Foo
        {
            private Bar bar;

            public Foo()
            {
                bar = new Bar(this);
            }
        }





        class Base
        {
            int pole;
        }

        class Kid : Base
        {
            int pole;
            public Kid()
            {
                base.pole = 25;
                pole = 100;
            }
        }




        class Class1
        {
            protected int value;

            public Class1(int value)
            {
                this.value = value;
            }
        }

        class Class2 : Class1
        {
            int value2;

            public Class2(int value, int value2)
                : base(value)
            {
                this.value2 = value2;
            }
        }
    }
}