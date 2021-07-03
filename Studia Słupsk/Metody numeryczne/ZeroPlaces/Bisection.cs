using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlaces
{
    public class Bisection
    {
        double function(double x)
        {
            return Math.Round(((x * x * x) - x + 1), 4);
        }

       public void write()
        {
            Console.WriteLine("Metoda bisekcji");
            Console.WriteLine("Miejsce zerowe znajduje sie w punkcie:" + x0 + " Ilosc krokow:" + i + " Czas wykonania:" + sw.Elapsed);
        }
        
        void counting()
        {
            do
            {
                sw.Start();
                x0 = Math.Round(((left + right) / 2), 4);
                f0 = Math.Round(function(x0), 4);
                fa = Math.Round(function(left), 4);

                if (f0 * fa < 0)
                {
                    right = x0;
                    i++;
                }
                else
                {
                    left = x0;
                    i++;
                }
            } while (Math.Abs(f0) > epsilon);
            sw.Stop();
        }

        double f0, fa, x0,left=0,right=0;
        double epsilon = 0.0001;
        int i = 0;
        Stopwatch sw = new Stopwatch();
        public Bisection(double l, double r)
        {
            this.left = l;
            this.right = r;

            counting();
           
        }
    }
}
