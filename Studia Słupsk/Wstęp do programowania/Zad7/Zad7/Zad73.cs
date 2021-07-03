using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Zad73
    {
        public double[] Ran(int n)
        {
            double[] data = new double[n];
            Random rnd = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next();
            }
            return data;
        }
    }
}
