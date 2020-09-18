using System;

namespace _CSHARP_EXCEPTIONS_EXERCISES_02  //My own exception.
{
    class Program
    {
        static void Main(string[] args)
        {
            Age userAge = new Age();

            try  //Here it is looking for an exception.
            {
                userAge.checkAge(-10);  //The value cannot be below 0.
            }
            catch(MyOwnException ex)  //if it faund it...
            {
                Console.WriteLine(ex.Message);
            }
        }

        public class Age  
        {
            int age = 0;

            public void checkAge(int a)
            {
                age = a;

                if (age < 0)
                {
                    throw (new MyOwnException("Age cannot be less than 0."));  //"Throw" requires object which includes some exception class (here "MyOwnException").
                }
                else
                    Console.WriteLine("Correct age.");
            }
        }

        public class MyOwnException : ApplicationException  //My own exception heriting from ApplicationException class.
        {
            public MyOwnException(string text) : base(text)  //So the parameter requires text.
            {

            }
        }
    }
}
