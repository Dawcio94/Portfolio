using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
   public class Box
    {
        public double width { get; set; }
        public double height { get; set; }
        public double depth { get; set; }

        public double GetVolume(double w,double h,double d)
        {
            return w*h*d;
        }
        public double GetArea(double w,double h,double d)
        {
            return 2 * (w * d + h * d + w * h);
        }

        public override string ToString()
        {
            return "W:" + width + " H:" + height+" D:"+depth;
        }
    }
}
