using System;
using System.Threading;

namespace _CSHARP_STRUCTURAL_INSTRUCTIONS_EXERCISES_01
{
    class Program //Switch
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Possibilities();
        }


        public class A
        {
            public void Possibilities()
            {
                string mark = "Porsche";
                switch (mark)
                {
                    case "BMW":
                        Console.WriteLine("You have chosen BMW.");
                        break;
                    case "Porsche":
                        Console.WriteLine("You have chosen Porsche.");
                        break;
                    case "Audi":
                        Console.WriteLine("You have chosen Audi.");
                        break;
                    default:
                        Console.WriteLine("You have chosen another car.");
                        break;
                }
            }
        }
    }
}


