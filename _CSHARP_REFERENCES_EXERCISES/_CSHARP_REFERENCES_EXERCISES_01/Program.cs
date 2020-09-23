using System;

namespace _CSHARP_REFERENCES_EXERCISES_01 //Assignment operator ("=") and passing value / reference types to value / reference
{
    public class Person
    {
        public String Name { get; set; }
        public Person(string Name) { this.Name = Name; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("1");
            Person person2 = new Person("2");

            person2 = person1; //person1 copies its own address on person2
            Console.WriteLine(person1.Name); //1
            Console.WriteLine(person2.Name); //1

            person2.Name = "3";
            Console.WriteLine(person1.Name); //3
            Console.WriteLine(person2.Name); //3

            ChangeName(person2);
            Console.WriteLine(person1.Name); //4
            Console.WriteLine(person2.Name); //4

            ChangeNameByRef(ref person2);
            Console.WriteLine(person1.Name); //6
            Console.WriteLine(person2.Name); //7

            void ChangeName(Person person) //There is a connection ref-object - parameter is a copy of ref so it has connection to address .
            {
                person.Name = "4"; //It works - changes  and it will disappear when the method is finished.
                person = new Person("5"); //It works BUT it will  disappear when the method is finished.
            }

            void ChangeNameByRef(ref Person person)
            {
                person.Name = "6"; //It works - there is a connection ref-object.
                person = new Person("7"); //It works - there is a connection ref-object.
            }
        }
    }
}
