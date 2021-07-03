using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlaces
{
    public class Secant
    {
        double function(double x)
        {
            return Math.Round(((x * x * x) - x + 1), 4);
        }

       public void write()
        {
            Console.WriteLine("Metoda siecznych");
            Console.WriteLine("Miejsce zerowe znajduje sie w punkcie:" + x0 + " Ilosc krokow:" + i + " Czas wykonania:" + sw.Elapsed);
        }
        void counting()
        {
            sw.Start();
            fa = Math.Round(function(l), 4);
            fb = Math.Round(function(r), 4);
            do
            {
                x0 = Math.Round(((l * fb - r * fa) / (fb - fa)), 4);
                f0 = Math.Round(function(x0), 4);
                l = r;
                fa = fb;
                r = x0;
                fb = f0;
                i++;
            } while (Math.Abs(f0) > epsilon);
            sw.Stop();
        }

        double f0, fa, x0, fb,l,r;
        double epsilon = 0.0001;
        int i = 0;
        Stopwatch sw = new Stopwatch();

        public Secant(double l, double r)
        {

            this.l = l;
            this.r = r;
            counting();

        }
    }
}
