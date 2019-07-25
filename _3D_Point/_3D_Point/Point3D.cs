using System;

namespace Point_Struct
{
    struct Point3D : IPointer
    {
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #region IPointer Methods
        /// <returns>Area between 0,0 and x,y</returns>
        public double GetArea()
        {
            return x * y * z;
        }

        /// <param name="secPoint">Gets Point2D param</param>
        /// <returns>Return area between first point and second point</returns>
        public double GetArea(IPointer secPoint)
        {
            try
            {
                Point3D point3D = (Point3D)secPoint;
                return Math.Abs((point3D.x - x) * (point3D.y - y) * (point3D.z - z));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public double GetPerimeter()
        {
            return 3 * (x + y + z);
        }

        public double GetPerimeter(IPointer secPoint)
        {
            try
            {
                Point3D point3D = (Point3D)secPoint;
                return 3 * (Math.Abs(point3D.x - x) + Math.Abs(point3D.y - y) + Math.Abs(point3D.z - z));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public double GetLenghth()
        {
            return Math.Sqrt(x * x + y * y + z*z);
        }

        public double GetLenghth(IPointer secPoint)
        {
            try
            {
                Point3D point3D = (Point3D)secPoint;
                return Math.Sqrt(Math.Pow((point3D.x - x), 2) + Math.Pow((point3D.y - y), 2) + Math.Pow((point3D.z - z), 2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        string IPointer.GetType()
        {
            return "Point3D";
        }

        public bool TypeEquals(IPointer obj)
        {
            return obj is Point3D;
        }

        #endregion

        #region Object Overriding Methods

        public override bool Equals(object obj)
        {
            Point3D point = default(Point3D);
            if (obj is Point3D)
                point = (Point3D)obj;
            else
                return false;

            return point.x == x && point.y == y;
        }

        public override int GetHashCode()
        {
            return new Random().Next(100000, 999999);
        }

        public override string ToString()
        {
            return $"The type of {GetType()} have two points, x and y";
        }

        #endregion

    }
}
