using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad48
    {
        public void Pole()
        {
            Console.WriteLine("Podaj długość podstawy");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj długość wysokości");
            string h = Console.ReadLine();
            float a1 = float.Parse(a), h1 = float.Parse(h),p=0;
            p = (a1 * h1) / 2;
            Console.WriteLine("Pole trojkata wynosi:");
            Console.Write(p);
        }
    }
}
