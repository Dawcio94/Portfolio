using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad410
    {
        public void Modulo()
        {
            Console.WriteLine("Podaj liczbę");
            string a = Console.ReadLine();
            int l = int.Parse(a);
            if (l % 2 == 0)
            {
                Console.Write("Podana liczba jest parzysta");
            }
            else
            {
                Console.Write("Podana liczba nie jest parzysta");
            }
        }
    }
}
