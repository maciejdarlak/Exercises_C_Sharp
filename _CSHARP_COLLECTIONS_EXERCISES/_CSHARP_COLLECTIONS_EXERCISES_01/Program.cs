using System;
using System.Collections.Generic;
using System.Linq;


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
            Console.WriteLine("EXAMPLE NO.1");
            Console.WriteLine(people.Count);

            //>=26 years old
            Console.WriteLine("EXAMPLE NO.2");
            var peopleOver26 = people.Where(a => a.Age >= 26);
            peopleOver26.ToList().ForEach(a => Console.WriteLine(a.LastName));

            //Name Anna
            Console.WriteLine("EXAMPLE NO.3");
            var peopleAnna = people.Where(a => a.FirstName.Equals("Anna"));
            peopleAnna.ToList().ForEach(a => Console.WriteLine(a.LastName));

            //>25 years old and name Jan
            Console.WriteLine("EXAMPLE NO.4");
            var peopleOver25AndJan = people.Where(a => (a.Age >= 25) && (a.FirstName == "Anna"));
            peopleOver25AndJan.ToList().ForEach(a => Console.WriteLine(a.LastName));

            //The oldest person
            Console.WriteLine("EXAMPLE NO.5");
            var oldestPerson = people.OrderByDescending(a => a.Age).Take(1);
            oldestPerson.ToList().ForEach(a => Console.WriteLine(a.LastName));

            //Sum of all ages
            Console.WriteLine("EXAMPLE NO.6");
            var sumAges = people.Sum(a => a.Age);
            Console.WriteLine(sumAges);

            //Average age of all people
            Console.WriteLine("EXAMPLE NO.7");
            double averageAge = people.Average(a => a.Age);
            Console.WriteLine(averageAge);

            //The first person who is 26 years old
            Console.WriteLine("EXAMPLE NO.8");
            var first26YearsOld = people.FirstOrDefault(averageAge => averageAge.Age >= 26);
            Console.WriteLine(first26YearsOld.LastName);

            //A person whose age is equal to the average age of all persons
            Console.WriteLine("EXAMPLE NO.9");
            var averageAgePerson = people.Where(a => a.Age == people.Average(a => a.Age));
            averageAgePerson.ToList().ForEach(a => Console.WriteLine(a.LastName));


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
