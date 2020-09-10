using System;
using System.Collections.Generic;

namespace _CSHARP_COLLECTIONS_EXERCISES_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(1, "Jan", "Kowalski", 24));
            people.Add(new Person(2, "Jan", "Nowak", 26));
            people.Add(new Person(3, "Anna", "Gruszka", 28));
            //People count
            Console.WriteLine(people.Count);

            //Break line
            Console.WriteLine("\n");

            //People's names
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }

            //Break line
            Console.WriteLine("\n");

            //Finding a specific person
            Person personAge26 = people.Find(a => a.Age == 26);
            Console.WriteLine(personAge26.ToString());

            //Break line
            Console.WriteLine("\n");

            //Finding specyfic Names
            List<Person> janList = people.FindAll(a => a.FirstName.Equals("Jan"));
            Console.WriteLine(janList.ToString());                                    

            //As above but used a loop
            foreach (var item in people)
            {
                if (item.FirstName == "Jan")
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }
        }




        public class Person
        {
            public int PersonId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(int nPersonId, string sFirstName, string sLastName, int nAge)
            {
                PersonId = nPersonId;
                FirstName = sFirstName;
                LastName = sLastName;
                Age = nAge;
            }
        }
    }
}
