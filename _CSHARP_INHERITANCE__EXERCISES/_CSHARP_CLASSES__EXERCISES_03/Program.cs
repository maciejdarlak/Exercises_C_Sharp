using System;
using System.Collections.Generic;

namespace _CSHARP_CLASSES__EXERCISES_03
{
    class Program //Downcast example
    {
        static void Main(string[] args)
        {         
            Employee employee = new Employee(); 
            Employee employeeManager = new Manager(); 

            if (employee is Manager) Console.WriteLine("Employee is a manager."); //Not OK
            if (employeeManager is Manager) Console.WriteLine("EmployeeManager is a manager.");   //OK
        }

        public class Employee { }

        public class Manager : Employee { }
    }
}
