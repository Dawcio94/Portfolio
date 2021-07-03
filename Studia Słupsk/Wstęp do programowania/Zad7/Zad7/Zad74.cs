using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Zad74
    {
        public void Modulo(int n,out List<double>nieparz, out List<double>parz)
        {
            List<double> parzs = new List<double>();
           List<double> nieparzs = new List<double>();
            double[] data = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next();
                if (data[i] % 2 == 0)
                {
                    parzs.Add(data[i]);
                }
                else
                {
                   nieparzs.Add(data[i]);
                }
            }
            nieparz = nieparzs;
            parz = parzs;
            
        }
    }
}
