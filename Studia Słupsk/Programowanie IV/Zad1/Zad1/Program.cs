using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klasa Glowna");
            Glowna g = new Glowna();
            g.Oblicz();
            Console.WriteLine("Klasa Jeden");
            Jeden j = new Jeden();
            j.Oblicz();
            Console.WriteLine("Klasa Dwa");
            Dwa d = new Dwa();
            d.Oblicz();
            Console.ReadLine();
        }
    }
}
