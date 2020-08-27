//Write a program in C# Sharp to shows how the three parts of a query operation execute.


using System;
using System.Collections.Generic;
using System.Linq;

// Do a list of objects
// Then select the list for our conditions
// Then use foreach to print each item in the list

class LINQ01
{
    static void Main(string[] args)
    {
        List<Car> list = new List<Car>();

        Car car1 = new Car();
        car1.Id = 1;
        car1.Brand = "Audi";
        car1.Model = "RS6";

        Car car2 = new Car();
        car2.Id = 2;
        car2.Brand = "BMW";
        car2.Model = "M3";

        Car car3 = new Car();
        car3.Id = 3;
        car3.Brand = "Pagani";
        car3.Model = "Zonda";

        Car car4 = new Car();
        car4.Id = 4;
        car4.Brand = "Nissan";
        car4.Model = "GTR";

        list.Add(car1);
        list.Add(car2);
        list.Add(car3);
        list.Add(car4);

        list.Add(new Car { Id = 5, Brand = "Pontiac", Model = "GTO" });

        var sortedList = list.Select(a => a).Where(b => b.Id < 4).OrderBy(c => c.Id).ToArray();


        foreach (var item in sortedList)
        {
            Console.WriteLine(item.Brand + " " + item.Model);
        }
        Console.ReadKey();
    }

    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}