using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            void swop(ref double xx, ref double yy)
            { double zamiana = xx; xx = yy; yy = zamiana; }
            int k, max;
            Console.WriteLine("Podaj liczbe rzeczy");
            k = Convert.ToInt32(Console.ReadLine());
            double[] w = new double[k];
            double[] c = new double[k];
            double[] iloraz = new double[k];
            double[] numer = new double[k];
            int[] ile = new int[k];
            Console.WriteLine("Podaj wage plecaka");
            max = Convert.ToInt32(Console.ReadLine());

            int i;

            for (i = 0; i < k; i++)
            {
                Console.WriteLine("Podaj wage rzeczy numer  {0}", i);
                w[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj wartosc rzeczy numer  {0}", i);
                c[i] = Convert.ToInt32(Console.ReadLine());
                iloraz[i] = c[i] / w[i];
                numer[i] = i;
                ile[i] = 0;
            }

            int j;

            //sortowanie wg ilorazow

            for (i = 1; i < k; i++)
            {
                for (j = k - 1; j >= i; j--)
                {
                    if (iloraz[j] > iloraz[j - 1])
                    {
                        swop(ref iloraz[j], ref iloraz[j - 1]);
                        swop(ref w[j], ref w[j - 1]);
                        swop(ref c[j], ref c[j - 1]);
                        swop(ref numer[j], ref numer[j - 1]);
                    }
                }
            }

            //pakowanie

            double rm = 0;
            double wart = 0;
            i = 0;

            while ((rm < max) && (i < k))
            {
                if (rm + w[i] <= max)
                {
                    rm += w[i];
                    wart += c[i];
                    ile[(int)numer[i]]++;
                }
                else
                {
                    i++;
                }
            }
            
            for (i = 0; i < k; i++)
            {
                if (ile[i] != 0)
                {
                    Console.WriteLine("Rzecz numer{0}.Liczba wystapien{1}", i, ile[i]);
                }
            }
            
            Console.WriteLine("Masa plecaka={0}.Wartosc plecaka{1}", rm, wart);

            Console.ReadKey();
        }
    }
}
