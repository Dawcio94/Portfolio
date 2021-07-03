using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shapes
{
   public class Sixthrangle:Shape
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public Point p4 { get; set; }
        public Point p5 { get; set; }
        public Point p6 { get; set; }

        public double length1;
        public double length2;
        public double length3;
        public double length4;
        public double length5;
        public double length6;

        public List<Point> spoints = new List<Point>();

        public int number;

        public override string ToString()
        {
            return number + "." + GetType().Name;
        }

        public void Sort()
        {

            spoints = new List<Point>()
            {
                p1,p2,p3,p4,p5,p6
            };

            double miny = spoints.Min(x => x.Y);
            List<Point> points = spoints.FindAll(o => o.Y == miny);
            double minx = points.Min(o => o.X);

            Point pMin = spoints.Find(o => o.X == minx && o.Y == miny);
            spoints.Remove(pMin);

            List<Point> XY = new List<Point>();

            for (int i = 0; i < spoints.Count; i++)
            {
                Point p = new Point();
                p.X = spoints[i].X - pMin.X;
                p.Y = spoints[i].Y - pMin.Y;
                XY.Add(p);
            }

            List<KeyValuePair<int, double>> angles = new List<KeyValuePair<int, double>>();
            Vector vector = new Vector(pMin.X + 1, 0);

            for (int i = 0; i < XY.Count; i++)
            {
                Vector v = new Vector(XY[i].X, XY[i].Y);
                angles.Add(new KeyValuePair<int, double>(i, Vector.AngleBetween(vector, v)));
            }


            List<KeyValuePair<int, double>> anglessorted = angles.OrderBy(o => o.Value).ToList();

            List<Point> sorted = new List<Point>();

            for (int i = 0; i < anglessorted.Count; i++)
            {
                sorted.Add(spoints[anglessorted[i].Key]);
            }

            spoints.Clear();
            spoints.Add(pMin);

            foreach (Point p in sorted)
            {
                spoints.Add(p);
            }
        }

        public new double Area()
        {
            double stepone = 0;
            double steptwo = 0;
            for (int i = 0; i < spoints.Count-1; i++)
            {
                stepone += spoints[i].X * spoints[i + 1].Y;
                steptwo += spoints[i].Y * spoints[i + 1].X;
            }

            double result = (stepone - steptwo) / 2;
            return Math.Abs(result);


        }

        public new double Rounding()
        {
            length1 = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow(p1.Y - p2.Y, 2));
            length2 = Math.Sqrt(Math.Pow((p2.X - p3.X), 2) + Math.Pow(p2.Y - p3.Y, 2));
            length3 = Math.Sqrt(Math.Pow((p3.X - p4.X), 2) + Math.Pow(p3.Y - p4.Y, 2));
            length4 = Math.Sqrt(Math.Pow((p4.X - p5.X), 2) + Math.Pow(p4.Y - p5.Y, 2));
            length5 = Math.Sqrt(Math.Pow((p5.X - p6.X), 2) + Math.Pow(p5.Y - p6.Y, 2));
            length6 = Math.Sqrt(Math.Pow((p6.X - p1.X), 2) + Math.Pow(p6.Y - p1.Y, 2));
            double p = length1 + length2 + length3 + length4+length5+length6;
            return p;
        }
    }
}

