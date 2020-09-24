using System;
 
namespace _CSHARP_DELEGATES_EXERCISES_04 //Events
{
    class Program
    {      
        public class Inscription
        {
            //Declare delegate
            public delegate void ChangeDelegate(int x);
            //Declare event
            public event ChangeDelegate ChangeEvent;

            public void ChangeMethod(int y)
            {
                if (ChangeEvent != null)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
        }

        static void Main(string[] args)
        {
            Inscription inscription = new Inscription();
            inscription.ChangeEvent += new Inscription.ChangeDelegate(inscription.ChangeMethod); //Adding to event list the delegate with chosen method as a parameter.
            inscription.ChangeMethod(10);
            Console.WriteLine(); // Default value for the "Inscription" class is "null" so the answer is "2".
        }
    }
}
