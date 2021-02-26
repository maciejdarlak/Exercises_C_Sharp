using System;

namespace _CSHARP_CLASSES_EXERCISES_03
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                var a = new DateTime(2020, 7, 15, 10, 10, 10);
                var b = new DateTime(1410, 7, 15, 10, 10, 10);
                TimeSpan duration = a - b;
                Console.WriteLine(duration);
                Console.ReadKey();
            }
        }
    }
}
