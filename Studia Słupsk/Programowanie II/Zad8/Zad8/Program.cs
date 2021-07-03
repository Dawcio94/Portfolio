using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile jest nominalów");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] nom = new int[n];
            int[] licz = new int[n];
            int i;

            for( i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartosc nominalu");
                nom[i] = Convert.ToInt32(Console.ReadLine());
                licz[i] = 0;
            }

            Console.WriteLine("Reszta?");
            int r = Convert.ToInt32(Console.ReadLine());

            i = 0;

            while ((r > 0) && i < n)
            {
                if (r - nom[i] >= 0)
                {
                    licz[i] = licz[i]+ 1;
                    r = r - nom[i];
                }
                else
                {
                    i++;
                }
            }

           

            if (r > 0)
            {
                Console.WriteLine("Nie mozna wydac reszty");
            }
            else
            {
                for (i = 0; i < n; i++)
                {
                    if (licz[i] != 0)
                    {
                        Console.WriteLine("Nominal {0}-{1} sztuk",nom[i],licz[i]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
