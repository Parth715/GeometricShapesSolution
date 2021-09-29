using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Square : Rect
    {
        public Square(int SideLen) : base (SideLen, SideLen) { }  // the parameter is put into Rect as Rect(3, 3) and goes through the rect class
    }
}
