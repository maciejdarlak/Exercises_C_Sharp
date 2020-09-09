using System;

namespace _CSHARP_INHERITANCE_EXERCISES_04
{
    //The proof that the conversion of object types does not apply to objects but references which, by their type, can narrow the view of objects.
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D1 = new Point3D();
            point3D1.x = 10;
            point3D1.y = 20;
            point3D1.z = 30;

            Console.WriteLine("Point 3Dl");
            Console.WriteLine("x = " + point3D1.x);
            Console.WriteLine("y = " + point3D1.y);
            Console.WriteLine("z = " + point3D1.z);
            Console.WriteLine(" ");


            Point point1 = (Point)point3D1; //Narrowed down to base class...

            Console.WriteLine("Point");
            Console.WriteLine("x = " + point1.x);
            Console.WriteLine("y = " + point1.y);
            Console.WriteLine("z = " + point1.z); //...that's why point.z is out of scope
            Console.WriteLine(" ");


            Point3D point3D2 = (Point3D)point1;

            Console.WriteLine("point3D2");
            Console.WriteLine("x = " + point3D2.x);
            Console.WriteLine("y = " + point3D2.y);
            Console.WriteLine("z = " + point3D2.z);
            Console.WriteLine(" ");
        }

        public class Point
        {
            public int x;
            public int y;
        }

        public class Point3D : Point
        {
            public int z;
        }
    }
}