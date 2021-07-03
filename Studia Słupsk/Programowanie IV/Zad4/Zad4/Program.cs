using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{

    class Liczby
    {
        public List<int> a = new List<int>();
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Liczby> p = new List<Liczby>();

            Console.WriteLine("Podaj ilosc liczb");
            int n = int.Parse(Console.ReadLine());

            int i, j,y;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe naturalne");
                y = int.Parse(Console.ReadLine());
                Liczby x = new Liczby();
                x.a.Add(y);
                p.Add(x);
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (p[i].a[0]%p[j].a[0]==0)
                        {
                            p[i].a.Add(p[j].a[0]);
                        }
                    }
                }
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Liczba:" + p[i].a[0]);
                if (p[i].a.Count > 1)
                {
                    Console.Write("Podzielniki:");
                    for (j = 1; j < p[i].a.Count; j++)
                    {
                        Console.Write("   " + p[i].a[j]);
                    }
                }
                else
                {
                    Console.Write("Podzielniki:brak");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
