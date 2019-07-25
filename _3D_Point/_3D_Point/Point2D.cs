using System;

namespace Point_Struct
{
    struct Point2D : IPointer
    {
        private double x { get; }
        private double y { get; }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #region IPointer Methods
        /// <returns>Area between 0,0 and x,y</returns>
        public double GetArea()
        {
            return x * y;
        }

        /// <param name="secPoint">Gets Point2D param</param>
        /// <returns>Return area between first point and second point</returns>
        public double GetArea(IPointer secPoint)
        {
            try
            {
                Point2D point2D = (Point2D)secPoint;
                return Math.Abs((point2D.x - x) * (point2D.y - y));  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public double GetPerimeter()
        {
            return 2 * (x + y);
        }

        public double GetPerimeter(IPointer secPoint)
        {
            try
            {
                Point2D point2D = (Point2D)secPoint;
                return 2 * (Math.Abs(point2D.x - x) + Math.Abs(point2D.y - y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public double GetLenghth()
        {
            return Math.Sqrt(x*x + y*y);
        }

        public double GetLenghth(IPointer secPoint)
        {
            try
            {
                Point2D point2D = (Point2D)secPoint;
                return Math.Sqrt(Math.Pow((point2D.x - x), 2) + Math.Pow((point2D.y - y), 2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        string IPointer.GetType()
        {
            return "Point2D";
        }

        public bool TypeEquals(IPointer obj)
        {
            return obj is Point2D;
        }

        #endregion

        #region Object Overriding Methods

        public override bool Equals(object obj)
        {
            Point2D point = default(Point2D);
            if (obj is Point2D)
                point = (Point2D)obj;
            else
                return false;

            return point.x == this.x && point.y == this.y;
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
