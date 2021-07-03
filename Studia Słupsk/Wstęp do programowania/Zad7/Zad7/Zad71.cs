using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Zad71
    {
        public List<int>Fibo(int n)
        {
            List<int> list = new List<int>();
            int c=1, a=0;
            list.Add(0);
            while(c!=n)
            {
                list.Add(c);
                c += a;
                a = c - a;

            }
            return list;
        }
    }
}
