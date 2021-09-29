using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect : Quad
    {
        public new void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()} Area: {Area()}");
        }
        public int Area()
        {
            return LeftSide * Bottom;
        }
        
        public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB)//the parameter from square is passed from square into here so it would be rect(3, 3) which would be passed into quad
        {
            this.LeftSide = SideA;
            this.RightSide = SideA;
            this.Bottom = SideB;
            this.Top = SideB;
        }
    }
}
