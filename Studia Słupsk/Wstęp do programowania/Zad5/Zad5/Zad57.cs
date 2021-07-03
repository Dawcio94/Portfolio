using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Zad57
    {
        public int Fibo(int n)
        {
            
            if (n < 3)
            {
                return 1;
            }
            else
            {
                return Fibo(n-2)+Fibo(n-1);
            }
           
        }
    }
}
