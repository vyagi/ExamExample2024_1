using Geometry;
using System;

namespace GeometryTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            Console.WriteLine($"{p1.X},{p1.Y}");

            var p2 = new Point(5);
            Console.WriteLine($"{p2.X},{p2.Y}");

            var p3 = new Point(3,4);
            Console.WriteLine($"{p3.X},{p3.Y}");

            p2.Move(-1, -2);
            Console.WriteLine($"{p2.X},{p2.Y}");

            var s1 = new Segment(p2, new Point(-1, -2));
            Console.WriteLine(s1.Length);

            Console.WriteLine(p3.Distance());

            var pc1 = new PolygonalChain(new Point(1,1), new Point(2, 2));
            pc1.AddMidpoint(new Point(2,1));

            Console.WriteLine(pc1.Length);

            pc1.Move(3, 1);
            Console.WriteLine(pc1.Length);

            Console.WriteLine(p3);
        }
    }
}
