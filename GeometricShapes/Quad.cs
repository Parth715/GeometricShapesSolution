using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Quad
    {
        public int LeftSide { get; set; }
        public int RightSide { get; set; }
        public int Bottom { get; set; }
        public int Top { get; set; }

        public void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }

        public int Perimeter()
        {
            return LeftSide + RightSide + Bottom + Top;
        }
        public Quad(int LeftSide, int RightSide, int Bottom, int Top) {
            this.LeftSide = LeftSide;
            this.RightSide = RightSide;
            this.Bottom = Bottom;
            this.Top = Top;
        }
    }
}
