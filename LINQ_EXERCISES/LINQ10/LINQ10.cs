//Write a program in C# Sharp to find the n-th Maximum grade point achieved by the students from the list of students.

using System;
using System.Linq;
using System.Collections.Generic;


namespace LINQ10
{
    class LINQ10
    {
        static void Main(string[] args)
        {          
            List<Students> stuList = new List<Students>();
            stuList.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stuList.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stuList.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stuList.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stuList.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stuList.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stuList.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stuList.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stuList.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stuList.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            Console.WriteLine("Which maximum grade point you want to find?");
            int x = int.Parse(Console.ReadLine());

            /*  Linq selection:
                OrderByDescending() - arranging the collection from the highest to the lowest value by GrPoint
                Take() - select x first values
                ToList() - create a new list */

            var newStuList = stuList.OrderByDescending(a => a.GrPoint).Take(x).ToList();
            foreach (var item in newStuList)
            {
                Console.WriteLine($" Id : {item.StuId},  Name : {item.StuName},  achieved Grade Point : {item.GrPoint}");
            }
            Console.Read();
        }
    }

    public class Students
    {
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public int StuId { get; set; }
    }
}
