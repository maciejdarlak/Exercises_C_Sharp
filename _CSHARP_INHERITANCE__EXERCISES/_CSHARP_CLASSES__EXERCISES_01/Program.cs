using System;

namespace _CSHARP_INHERITANCE_EXERCISES_01
{
    class Program //Upcast example
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square(); //Upcast
            if (rectangle is Square)
            {
                Console.WriteLine("Success");
            }            
        }

        public class Rectangle
        {
            public int x = 10, y = 10;
            public int GetArea()
            {
                return x * y;
            }
        }

        public class Square : Rectangle
        {
            public int x = 5, y = 5;
            public int GetArea()
            {
                return x * y;
            }
        }
    }
}
