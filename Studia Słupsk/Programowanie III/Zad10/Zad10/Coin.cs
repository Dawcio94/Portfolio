using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad10
{
   public class Coin :Bone
    {
        public double radius { get; set; }
        public override double Area { get; }
        public override int[] Value { get; set; }
        public Coin(double k)
        {
            radius = k / (2 * Math.PI);
            Area = Math.PI * (Math.Pow(radius, 2));
            Value = new int[2];
            Value[0] = 0;
            Value[1] = 1;
        }
        
        
    }
}
