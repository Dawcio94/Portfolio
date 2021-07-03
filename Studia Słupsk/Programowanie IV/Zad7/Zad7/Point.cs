using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Point:IComparable
    {
        double x, y;

        public Point(double a,double b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return ("X=" + x + " Y=" + y);
        }

        public static Point operator +(Point p1,Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator ++(Point p1)
        {
            return new Point((p1.x++), (p1.y++));
        }

        public static bool operator == (Point p1,Point p2)
        {
            return (p1.x == p2.x && p1.y == p2.y);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.x != p2.x || p1.y != p2.y);
        }

        public int CompareTo(object o)
        {
            if(o is Point)
            {
                Point p = (Point)o;
                if(this.x>p.x && this.y > p.y)
                {
                    return 1;
                }
                else
                {
                    if(this.x<p.x && this.y < p.y)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }  
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }
    }
}
