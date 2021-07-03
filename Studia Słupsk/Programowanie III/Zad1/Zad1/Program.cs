using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            a.X = 1.0;
            a.Y = 1.0;

            Point b = new Point();
            b.X = 5.0;
            b.Y = 3.0;

            LineSegment line = new LineSegment();
            line.SetPoint1(a);
            line.SetPoint2(b);

            Console.WriteLine(line.GetCenter().X.ToString() + ";" + line.GetCenter().Y.ToString());
            Console.WriteLine(line.GetLength().ToString());
            Console.ReadKey();
        }
    }
}
