using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad49
    {
        public void Porownaj()
        {
            Console.WriteLine("Podaj pierwsza liczbę");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę");
            string b = Console.ReadLine();
            int a1 = int.Parse(a),a2 = int.Parse(b);
            if (a1>a2){
                Console.Write("Wieksza liczba to:"+a1);
            }
            else
            {
                Console.Write("Wieksza liczba to:" + a2);
            }
        }
    }
}
