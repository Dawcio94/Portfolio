using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad7
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Podaj liczbe elementow tablicy");
            int n = int.Parse(Console.ReadLine());

            GTab<int> integ = new GTab<int>(n);
            GTab<string> str = new GTab<string>(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartosc elementu o indeksie" + (i + 1));
                int y = int.Parse(Console.ReadLine());
                integ.Ustaw(i, y);
            }

            integ.change(integ, n);

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartosc elementu o indeksie" + (i + 1));
                string y = (Console.ReadLine());
                str.Ustaw(i, y);
            }

            str.change(str, n);

            Console.ReadKey();
        } 
    }
}
