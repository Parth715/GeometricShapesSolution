using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect
    {
        public int SideLen1 { get; set; }
        public int SideLen2 { get; set; }

        public int Perimeter()
        {
            return SideLen1 * 2 + SideLen2 * 2;
        }
        public int Area()
        {
            return SideLen2 * SideLen1;
        }

    }
}
