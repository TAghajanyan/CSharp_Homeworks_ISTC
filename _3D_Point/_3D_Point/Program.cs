using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Struct
{
    class Program
    {
        static void Result(IPointer obj1, IPointer obj2)
        {
            Console.WriteLine("Method Equals: " + obj1.Equals(obj2));
            Console.WriteLine("Method TypeEquals: " + obj1.TypeEquals(obj2));

            Console.WriteLine("Area (0,0): " + obj1.GetArea());
            Console.WriteLine("Area (second point): " + obj1.GetArea(obj2));

            Console.WriteLine("Length (0,0): " + obj1.GetLenghth());
            Console.WriteLine("Length (second point): " + obj1.GetLenghth(obj2));

            Console.WriteLine("Perimeter (0,0): " + obj1.GetPerimeter());
            Console.WriteLine("Perimeter (second point): " + obj1.GetPerimeter(obj2));

            Console.WriteLine("Type: " + obj1.GetType());
            Console.WriteLine("Method ToString: " + obj1.ToString());
            Console.WriteLine("Hash code: " + obj1.GetHashCode());
        }

        static void Main(string[] args)
        {
            Point2D firstPoint2D = new Point2D(4,6);
            Point2D secondPoint2D = new Point2D(9,2);

            Result(firstPoint2D, secondPoint2D);

            Console.WriteLine(new string('-', 30));

            Point3D firstPoint3D = new Point3D(2, 3, 5);
            Point3D secondPoint3D = new Point3D(5, 4, 1);

            Result(firstPoint3D, secondPoint3D);

        }
    }
}
