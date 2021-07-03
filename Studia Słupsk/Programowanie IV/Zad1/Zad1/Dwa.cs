using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Dwa:Glowna
    {
        public Dwa() { }

        public override int W(int n)
        {
            return 4-n*n;
        }
    }
}
