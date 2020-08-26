using System;

namespace _CSHARP_CLASSES__EXERCISES_01
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





        class Baza
        {
            int pole;
        }

        class Pochodna : Baza
        {
            int pole;
            public Pochodna()
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
