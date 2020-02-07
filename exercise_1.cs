using System;
using System.Collections.Generic;
using System.Linq;


//Robimy listę obiektów.
//Potem selekcja listy o nasze warunki.
//Potem za pomocą foreach wypisanie każdego elementu listy.

class Program
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
            Console.WriteLine(item.Brand + " " +  item.Model);          
        }
        Console.ReadKey();
    }
}