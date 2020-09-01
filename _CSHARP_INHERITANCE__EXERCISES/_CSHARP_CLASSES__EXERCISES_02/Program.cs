using System;
using System.Collections.Generic;

namespace _CSHARP_CLASSES__EXERCISES_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cast up
            Example.DeriveredClass a = new Example.DeriveredClass();
            if (a is Example.SomeBaseClass)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Wrong");

            //Cast down
            Example.DeriveredClass2 b = a as Example.DeriveredClass2;
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
            public class DeriveredClass2 : DeriveredClass { };
            public class OtherDeriveredClas : SomeBaseClass { };
        }
    }
}




