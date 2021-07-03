using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad61
    {
        public void Compare(int a,int b,out string s,out int c)
        {
            s = "";
            c = 0;
            if (a > b)
                c = a;
            else if (b > a)
                c = b;
            else
                s = "Są równe";
        }
    }
}
