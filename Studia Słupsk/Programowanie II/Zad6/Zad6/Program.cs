using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Podaj liczbe elementów");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[k];
            for (i = 0; i < k; i++)
            {
                Console.WriteLine("Podaj kolejny element");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Jakiego elementu poszukujesz?");
            int x = Convert.ToInt32(Console.ReadLine());

            bool t = true;
            int l=0, p=k-1,s,s1;

            while (t)
            {
                if (a[p]==a[l])
                {
                    s = p;
                }
                else
                {
                    s1 = l + (p - l) * (x - a[l]) / (a[p] - a[l]);
                    s = Math.Min(s1, p);
                    if (s1 < p)
                    {
                        s = s1;
                    }
                    else
                    {
                        s = p;
                    }
                }
                if (x == a[s])
                {
                    Console.WriteLine("Numer miejsca" + (s + 1));
                    t = false;
                }
                else
                {
                    if (a[s] < x)
                    {
                        l = s + 1;
                    }
                    else
                    {
                        p = s - 1;
                    }
                }
                if (l > p)
                {
                    Console.WriteLine("Nie ma takiego elementu");
                    t = false;
                }
            }
            Console.ReadKey();
        }
    }
}
