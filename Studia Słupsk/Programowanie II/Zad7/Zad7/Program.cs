using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
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
            

            void QuickSort(int s,int f)
            {
                int l = s, p = f,zamiana=0;

                int sr = (l + p) / 2;
                while (l <= p)
                {
                    while (a[l] < a[sr])
                    {
                        l++;
                    }
                    while (a[p] > a[sr]) {
                        p--;
                    }
                    if (l <= p)
                    {
                        zamiana = a[l];
                        a[l] = a[p];
                        a[p] = zamiana;
                        l++;
                        p--;
                    }
                }
                if (s < p)
                {
                    QuickSort(s, l);
                }
                if (f > l)
                {
                    QuickSort(s, l);
                }
            }

            QuickSort(0, k-1);

            for (i = 0; i < k; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
