using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlaces
{
    public class Falsi
    {
        double function(double x)
        {
           return Math.Round(((x * x * x) - x + 1), 4);
        }

       public void write()
        {
            Console.WriteLine("Metoda falsi");
            Console.WriteLine("Miejsce zerowe znajduje sie w punkcie:" + x0 + " Ilosc krokow:" + i + " Czas wykonania:" + sw.Elapsed);
        }

        void counting()
        {
            do
            {
                sw.Start();
                fa = Math.Round(function(ll), 4);
                fb = Math.Round(function(rr), 4);
                x0 = Math.Round(((ll * fb - rr * fa) / (fb - fa)), 4);
                f0 = Math.Round(function(x0), 4);
                if (f0 * fa < 0)
                {
                    rr = x0;
                    i++;
                }
                else
                {
                    ll = x0;
                    i++;
                }
            } while (Math.Abs(f0) > epsilon);
            sw.Stop();
        }

        double f0, fa, x0, fb,ll,rr;
        double epsilon = 0.0001;
        int i = 0;
        Stopwatch sw = new Stopwatch();

        public Falsi(double ll, double rr)
        {
            this.ll = ll;
            this.rr = rr;
            counting();
        }
    }
}
