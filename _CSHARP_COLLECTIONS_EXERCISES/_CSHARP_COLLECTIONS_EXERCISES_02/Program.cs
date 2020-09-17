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
                {"85010156124", new Person("Anna", "Lewandowska", 27)},
                {"84010156123", new Person("Andrzej", "Wiśniewski", 28)}
            };


            //All people list
            Console.WriteLine("EXAMPLE NO.1");
            var allPeople = people.Select(a => a.Value);
            allPeople.ToList().ForEach(a => Console.WriteLine(a.LastName + " " + a.FirstName));

            //>=26 years old, ordered by last name and then by first name
            Console.WriteLine("EXAMPLE NO.2");
            var age26 = people.Where(a => a.Value.Age >= 26).OrderBy(a => a.Value.LastName).ThenBy(a => a.Value.FirstName);
            age26.ToList().ForEach(a => Console.WriteLine(a.Value.LastName + " " + a.Value.FirstName));

            //>=26 years old and name Anna, ordered by last name and then by first name
            Console.WriteLine("EXAMPLE NO.3");
            var age26Annas = people.Where(a => (a.Value.FirstName == "Anna") && (a.Value.Age >= 26));
            age26Annas.ToList().ForEach(a => Console.WriteLine(a.Value.LastName + " " + a.Value.FirstName));

            //Pesel starts 85, ordered by last name and then by first name
            Console.WriteLine("EXAMPLE NO.4");
            var peselPeople = people.Where(a => a.Key.StartsWith("85")).OrderBy(a => a.Value.LastName).ThenBy(a => a.Value.FirstName);
            peselPeople.ToList().ForEach(a => Console.WriteLine(a.Value.LastName + " " + a.Value.FirstName));
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
