using System;
using System.Collections.Generic;
using System.Linq;

namespace _CSHARP_COLLECTIONS_EXERCISES_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>()
            {
                {"86010156123", new Person("Jan", "Kowalski", 26)},
                {"87010156123", new Person("Anna", "Krawczyk", 25)},
                {"88010156123", new Person("Krzysztof", "Nowak", 24)},
                {"85010156123", new Person("Katrzyna", "Lewandowska", 27)},
                {"84010156123", new Person("Andrzej", "Wiśniewski", 28)}
            };


            //All people list
            Console.WriteLine("EXAMPLE NO.1");
            var allPeople = people.Select(a => a.Value);
            allPeople.ToList().ForEach(a => Console.WriteLine(a.LastName));












        }


        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string sFirstName, string sLastName, int nAge)
            {
                FirstName = sFirstName;
                LastName = sLastName;
                Age = nAge;
            }
        }
    }
}
