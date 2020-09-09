using System;

namespace _CSHARP_INHERITANCE_EXERCISES_06
{
   
    class Program //Abstract class
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.DoSth();
        }


        abstract public class A
        {
            abstract public void DoSth();
        }

        public class B : A
        {
            override public void DoSth()
            {
                Console.WriteLine("B");
            }
        }
    }
}
