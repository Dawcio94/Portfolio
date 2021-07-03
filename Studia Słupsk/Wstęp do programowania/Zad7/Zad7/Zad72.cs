using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Zad72
    {
        public string Geo()
        {
            double[]tab = new double[50];
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = 1 * (Math.Pow(2,i));
            }
            double q = tab[1] / tab[0];
            double sum = tab[0] * ((1 -(Math.Pow(q, 50)))/(1-q));
            double aver = sum / 50;
            double mid = (tab[(50/2)-1] + tab[(50/2)]) / 2;
            return "Suma rowna sie: "+ sum+"Srednia to: "+aver+".Mediana rowna sie: "+mid;
        }
    }
}
