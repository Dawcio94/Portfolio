using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad37
    {
        public void Dip()
        {
            double a = 5, b = 3, k = 30,c=0,s=0;
            s = (a * b * Math.Sin((Math.PI * 30) / 180))/2;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos((Math.PI * k) / 180));
            Console.WriteLine("Pole powierzchni to: "+s + "a długość boku c to: " + c);
        }
    }
}
