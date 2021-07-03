using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shapes
{
    public class Triangle:Shape
    {
        public Point p1 { get; set; }
        public Point p2{ get; set; }
        public Point p3 { get; set; }

        public double length1;
        public double length2;
        public double length3;

        public int number;

        public override string ToString()
        {
            return number + "." + GetType().Name;
        }

        public new double Area()
        {
            double stepone = p1.X * p2.Y + p2.X * p3.Y;
            double steptwo = p1.Y * p2.X + p2.Y * p3.X;
            double result = (stepone - steptwo) / 2;
            return Math.Abs(result);

        }

        public new double Rounding()
        {
            length1 = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow(p1.Y - p2.Y, 2));
            length2 = Math.Sqrt(Math.Pow((p2.X - p3.X), 2) + Math.Pow(p2.Y - p3.Y, 2));
            length3 = Math.Sqrt(Math.Pow((p3.X - p1.X), 2) + Math.Pow(p3.Y - p1.Y, 2));
            double p = length1 + length2 + length3;
            return p;

        }
    }
}
