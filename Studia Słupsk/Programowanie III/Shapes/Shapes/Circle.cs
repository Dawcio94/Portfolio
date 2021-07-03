using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shapes
{
    public class Circle : Shape
    {
        
        public Point s { get; set; }
        public Point k { get; set; }
        public double length { get; set; }
        public int number;

        public override string ToString()
        {
            return number+"."+GetType().Name;
        }

        public new double Area()
        {
             length = Math.Sqrt(Math.Pow((s.X - k.X), 2) + Math.Pow(s.Y - k.Y, 2));
             return (Math.PI * Math.Pow(length, 2));
            
        }
          public new double Rounding()
        {
            length = Math.Sqrt(Math.Pow((s.X - k.X), 2) + Math.Pow(s.Y - k.Y, 2));
            return 2 * Math.PI * length;
        }   
    }
}
    

