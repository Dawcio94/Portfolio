using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Glowna:Iwyr
    {
        public int stala => Convert.ToInt32(Console.ReadLine());
        public int W(int n)
        {
            return n * n + 2+stala;
        }
    }
}
