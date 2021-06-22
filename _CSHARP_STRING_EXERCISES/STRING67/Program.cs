using System;


/*  Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.
    Examples
    ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
    ReverseCase("MANY THANKS") ➞ "many thanks"
    ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS" */


namespace STRING67
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            var result = a.ReverseString("doGS are FUNNY.");
            Console.WriteLine(result);
        }

        public class A
        {
            public string ReverseString(string stringToChange)
            {
                char[] array1 = stringToChange.ToCharArray(); // Changed to char array.
                string result = "";

                foreach (var item in array1)
                {
                    if (char.IsUpper(item)) 
                    {
                        result += item.ToString().ToLower();
                    }
                    if (char.IsLower(item))
                    {
                        result += item.ToString().ToUpper();
                    }
                    if (!char.IsUpper(item) && !char.IsLower(item))
                    {
                        result += item.ToString();
                    }
                }
                return result;
            }
        }
    }
}