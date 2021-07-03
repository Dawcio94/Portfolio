using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class LineSegment
    {
        public Point point1=new Point();
        public Point point2 = new Point();
        
        public void SetPoint1(Point a)
        { 
            point1=a;
           
        }
        public void SetPoint2(Point b)
        {
            point2 = b;
            
           

        }

        public Point GetCenter()
        {
            double midX = ((point1.X + point2.X) / 2);
            double midY = ((point1.Y+point2.Y)/ 2);
            Point pointc = new Point
            {
                X = midX,
                Y = midY
            };
            return pointc;
        }
            
        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow(point1.Y - point2.Y, 2));
            return length;
        }


    }
}
