using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlaces
{
    public class Tangent
    {
        double function(double x)
        {
            return Math.Round(((x * x * x) - x + 1),4);
        }

        double pfunction(double x)
        {
            return Math.Round((3*x*x - 1),4);
        }
       public void write()
        {
            Console.WriteLine("Metoda stycznych");
            Console.WriteLine("Miejsce zerowe znajduje sie w punkcie:" + x0 + " Ilosc krokow:" + i + " Czas wykonania:" + sw.Elapsed);
        }
        void counting()
        {
            sw.Start();
            do
            {
                f0 = Math.Round(function(x0), 4);
                fp0 = Math.Round(pfunction(x0), 4);
                h0 = Math.Round(((-f0) / fp0), 4);
                x0 += h0;
                i++;
            } while (Math.Abs(f0) > epsilon);
            sw.Stop();
            
        }

        int i;
        double f0, fp0, h0,x0;
        double epsilon = 0.0001;
        Stopwatch sw = new Stopwatch();
        
        public Tangent(double x0)
        {
            this.x0 = x0;
            counting();
        }
    }

}
