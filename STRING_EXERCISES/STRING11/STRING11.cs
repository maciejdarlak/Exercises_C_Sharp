//Write a C # program to check the nearest 20 value of the two given integers and return 0 if the two numbers are the same.

using System;

//Kluczowea metoda to wartość bezwzględna: Math.Abs()
//Potem zgrabna metoda warunkowa o konstrukcji: warunek? wyrazenie_w_przypadku_prawdy : wyrazenie_w_przypadku_falszu

namespace STRING11
{
    class STRING11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
            Console.ReadKey();
        }
    }
}
