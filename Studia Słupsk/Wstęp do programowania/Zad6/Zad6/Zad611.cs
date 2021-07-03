using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad611
    {
        public void Power()
        {
            int a,w=1;
            Console.WriteLine("Podaj liczbe do obliczenia silni");
            a = int.Parse(Console.ReadLine());

            while (a > 1)
            {
                w *=a;
                a--;  
            }
            Console.Write("Silnia rowna sie:" + w);
        }
    }
}
