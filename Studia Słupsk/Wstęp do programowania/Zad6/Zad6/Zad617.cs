using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad617
    {
        public int NWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }


        public int NWW(int a,int b)
        {

            return (a * b) / NWD(a, b);
            
        }
    }
}
