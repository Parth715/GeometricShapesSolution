using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square()
            {
                Side = 5
            };
            Console.WriteLine($"Perimeter of the square is {s1.Perimeter()}");
            Console.WriteLine($"Area of the square is {s1.Area()}");
            var r1 = new Rect()
            {
                SideLen1 = 3,
                SideLen2 = 5,
            };
            Console.WriteLine($"Perimeter of the Rectangle is {r1.Perimeter()}");
            Console.WriteLine($"Area of the rectangle is {r1.Area()}");
            var q1 = new Quad()
            {
                LeftSide = 3,
                RightSide = 4,
                Bottom = 5,
                Top = 6
            };
            
            
            Console.WriteLine($"Perimeter of the quadrilateral is {q1.Perimeter()}");

        }
    }
}
