using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Glowna
    {
        public int nr, lw;

        public Glowna()
        {
            Console.WriteLine("Podaj numer poczatkowy");
            nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe wyrazow");
            lw = Convert.ToInt32(Console.ReadLine());
        }

        public virtual int W (int n)
        {
            return n * n + 2;
        }

        public void Oblicz()
        {
            int suma=0, iloczyn=1;
            for(int i = nr; i <= nr+lw-1; i++)
            {
                suma += W(i);
                iloczyn *= W(i);
            }
            Console.WriteLine("Suma rowna sie" + suma);
            Console.WriteLine("Iloczyn rowna sie" + iloczyn);
        }
    }
}
