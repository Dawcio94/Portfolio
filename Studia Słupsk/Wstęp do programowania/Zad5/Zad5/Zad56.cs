using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Zad56
    {
        public int Silnia(int n)
        {
            if(n==0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n*Silnia(n-1);
            }
        }
    }
}
