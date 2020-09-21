using System;

namespace _CSHARP_DELEGATES_EXERCISES_02  //Delegate as a method parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Transform(10, Square);
            int B = Transform(2, Volume);
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
        public static int Square(int a) => a * a;  //1
        public static int Volume(int a) => a * a * a;  //1

        public delegate int Operation(int x);  //2

        public static int Transform(int value, Operation operation)  //3
        {
            int result = operation(value);
            return result;
        }     
    }
}
