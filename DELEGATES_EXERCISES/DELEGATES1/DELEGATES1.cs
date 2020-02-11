using System;

// The delegate can refer to a method that has the same signature as the delegate
// In the Main method we initiate a delegate who points to specific methods
// Now we can add them or anything else
// If we want to have different values in 2 delegates, we must create 2 delegate objects

namespace DELEGATES1
{
    class DELEGATES1
    {
        static void Main(string[] args)
        {
            Data.Shortcut d1 = new Data.Shortcut(Data.Add);
            Data.Shortcut d2 = new Data.Shortcut(Data.Subtract);

            Console.WriteLine(d1(2, 2) + d2(4, 3));
            Console.ReadKey();
        }
    }

    static public class Data
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public delegate int Shortcut(int x, int y);
    }
}
