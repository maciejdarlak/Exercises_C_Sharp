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

            //Cast down - 1st way
            if (a is Example.DeriveredClass2)
            {
                Example.DeriveredClass2 b = (Example.DeriveredClass2)a; 
                Console.WriteLine("OK");
            }
            else
                    Console.WriteLine("Wrong");

            //Cast down - 2nd way
            Example.DeriveredClass2 c = a as Example.DeriveredClass2;
            if (c != null)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Wrong");
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




