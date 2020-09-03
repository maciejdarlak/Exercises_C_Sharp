using System;
using System.Collections.Generic;

namespace _CSHARP_CLASSES__EXERCISES_03
{
    class Program //Downcast example
    {
        static void Main(string[] args)
        {         
            Employee employee = new Employee(); 
            Employee employee2 = new Manager(); 

            if (employee is Manager) Console.WriteLine("Employee is a manager."); //Not OK
            if (employee2 is Manager) Console.WriteLine("Employee2 is a manager.");   //OK

            //Or

            Employee someEmployee = employee as Manager;
            if (someEmployee != null)   Console.WriteLine("Employee is a manager.");

            Employee someEmployee2 = employee2 as Manager;
            if (someEmployee2 != null)   Console.WriteLine("Employee2 is a manager.");
        }

        public class Employee { }

        public class Manager : Employee { }
    }
}
