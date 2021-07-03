using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m1 = 0, m2 = 0;
            Console.WriteLine("Podaj liczbe elementów");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[k];
            for (i = 0; i < k; i++)
            {
                Console.WriteLine("Podaj kolejny element");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            void min_max(int m, int n, ref int min, ref int max)
            {
                int max1 = 0, min1 = 0, max2 = 0, min2 = 0;
                if (m == n) { min = a[m]; max = min; }
                else
                {
                    if (m == n - 1)
                    {
                        if (a[m] < a[n]) { min = a[m]; max = a[n]; }
                        else { min = a[n]; max = a[m]; }
                    }
                    else
                    {
                        min_max(m, (m + n) / 2, ref min1, ref max1);
                        min_max((m + n) / 2 + 1, n, ref min2, ref max2);
                        if (min1 < min2) { min = min1; } else { min = min2; }
                        if (max1 > max2) { max = max1; } else { max = max2; }
                    }
                }
            }
            min_max(0, k - 1, ref m1, ref m2);
            Console.WriteLine("Najmniejszy={0}", m1);
            Console.WriteLine("Największy={0}", m2);
            Console.ReadKey();

        }
    }
}
