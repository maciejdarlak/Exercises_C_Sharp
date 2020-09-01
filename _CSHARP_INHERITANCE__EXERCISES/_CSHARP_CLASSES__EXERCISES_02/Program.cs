using System;
using System.Collections.Generic;

namespace _CSHARP_CLASSES__EXERCISES_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Example.DeriveredClass a = new Example.DeriveredClass();
            if (a is Example.OtherDeriveredClas)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Never");


            Example.SomeInterface b = a as Example.SomeInterface;
            if (b != null)
            {
                Console.WriteLine("OK 2");
            }
        }


        public class Example
        {
            public interface SomeInterface { };
            public class SomeBaseClass : SomeInterface { };
            public class DeriveredClass : SomeBaseClass { };
            public class OtherDeriveredClas : SomeBaseClass { };
        }
    }
}




