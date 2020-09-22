using System;

namespace _CSHARP_CLASSES_EXERCISES_02 //Copying values of reference types
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
            Console.WriteLine(person2.Name); //

            ChangeNameByRef(ref person2);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);








            void ChangeName(Person person)
            {
                person.Name = "4";
                person = new Person("5");
            }

            void ChangeNameByRef(ref Person person)
            {
                person.Name = "6";
                person = new Person("7");
            }
        }
    }
}
