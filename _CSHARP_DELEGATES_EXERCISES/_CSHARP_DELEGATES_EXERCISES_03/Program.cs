using System;

namespace _CSHARP_DELEGATES_EXERCISES_03 //Multicasting
{  
    class Program
    {
        public delegate int ChangeNumber(int value);  //Delegate

        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            ChangeNumber cn;
            ChangeNumber cn1 = new ChangeNumber(numbers.AddNumber);
            ChangeNumber cn2 = new ChangeNumber(numbers.MultiplayNumber);
            cn = cn1;
            cn += cn2;           
            Console.WriteLine(cn(5));
        }
       
        public class Numbers  //Methods       
        {
            public int number = 5;

            public int AddNumber(int x)
            {
                return number += x;
            }

            public int MultiplayNumber(int y)
            {
                return number *= y;
            }
        }
    }
}
