using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad610
    {
        public void Pow()
        {
            int a;
            Console.WriteLine("Podaj koniec zakresu");
            a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                Console.Write((i * i)+" ");
            }
        }
    }
}
