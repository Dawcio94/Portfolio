using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Triangle
    {
        double xa, ya, xb, yb, xc, yc;

        Point 
        public Triangle(Point p1,Point p2,Point p3)
        {
            
            Point A = new Point(xa, ya);
            Point B = new Point(xb, yb);
            Point C = new Point(xc, yc);
            Point A = p1;

        }
        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            return new Triangle (t1.xa);
        }

    }
}
