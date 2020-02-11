//Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

using System;
using System.Collections.Generic;
using System.Linq;

// Do a list of objects.
// Select the list for our conditions.
// Use foreach to print each item in the list.

namespace LINQ2
{
    class LINQ2
    {
        static void Main(string[] args)
        {
            List<Car> naszePojazdy = new List<Car>()
        {
            new Car("Audi A6 Quatro", Car.Type.NormalCar, 360000, "Black"),
            new Car("Mercedes Benz", Car.Type.NormalCar, 390000, "White"),
            new Car("Volvo Truck", Car.Type.Truck, 160000, "Blue"),
            new Car("Iveco Horse", Car.Type.Truck, 120000, "Black"),
            new Car("Ford Mondeo", Car.Type.NormalCar, 70000, "Black"),
        };

            var selectedCars = naszePojazdy.Select(a => a).Where(a => a.Prize < 200000).Where(a => a.Color == "Black").Where(a => a.CarType == Car.Type.NormalCar).OrderBy(a => a.Prize).ToList();

            foreach (var item in selectedCars)
            {
                Console.WriteLine($"{item.Brand}  {item.CarType}  {item.Prize}  {item.Color}");
            }
            Console.ReadKey();
        }
    }
    public class Car
    {
        public Car(string brand, Type type, decimal prize, string color)
        {
            this.Brand = brand;
            this.CarType = type;
            this.Prize = prize;
            this.Color = color;
        }

        public string Brand { get; set; }
        public Type CarType { get; set; }
        public decimal Prize { get; set; }
        public string Color { get; set; }

        public enum Type
        {
            NormalCar, Truck
        }
    }
}
