namespace StructExample
{
    internal class Program
    {
        static void Method(in Point p)
        {
            
        }

        static Point FindPoint(Point find, params Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                var point = points[i];
                if (point.X == find.X && point.Y == find.Y)
                {
                    return point;
                }
            }

            return new Point();
        }


        static void Main()
        {
            Point point1 = new (10, -3, 0);
            Point point2 = new (10, -3, 0);

            if (point1.Equals(point2))
            {              
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            Console.WriteLine(point1.GetHashCode());
            Console.WriteLine(point2.GetHashCode());


            Method(point1);

            Console.WriteLine(point1.Z);

            Point result = FindPoint(in new Point(1, 1, 1), point1, point2);

            if (result.IsEmpty)
            {
                Console.WriteLine("We do not have such point");
            }
            else
            {
                Console.WriteLine(result.X);
                Console.WriteLine(result.Y);
                Console.WriteLine(result.Z);
            }


        }
    }
}
