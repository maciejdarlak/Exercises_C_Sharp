using System;
using System.Collections.Generic;

namespace _CSHARP_INHERITANCE_EXERCISES_02
{
    class Program //Upcast and downcast example
    {
        static void Main(string[] args)
        {
            //Upcast
            Example.DeriveredClass a = new Example.DeriveredClass();
            if (a is Example.SomeBaseClass)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Wrong");

            //Downcast  - 1st way
            if (a is Example.DeriveredClass2)
            {
                Example.DeriveredClass2 b = (Example.DeriveredClass2)a;
                Console.WriteLine("OK");
            }
            else
                Console.WriteLine("Wrong");

            //Downcast - 2nd way
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
