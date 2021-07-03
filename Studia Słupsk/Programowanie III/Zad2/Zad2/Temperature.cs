using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Temperature
    {
        double kelwintemp=0;

        public double Getkelwintemp()
        {
            return kelwintemp;
        }
        public void Setkelwintemp(double k)
        {
            this.kelwintemp = k;
        }

        public double GetCeltemp()
        {
            return kelwintemp - 273.15;
        }
        public void Setkelfromcel(double c)
        {
            this.kelwintemp = c + 273.15;
        }

        public double Getfartemp()
        {
            return (GetCeltemp() * 1.8) + 32;
        }

        public void Setkelfromfar(double f)
        {
            this.kelwintemp = ((f-32)/1.8)+273.15;
        }

    }
}
