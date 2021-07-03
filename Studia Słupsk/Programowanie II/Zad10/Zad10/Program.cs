using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad10
{
    class Program
    {
        static void Main(string[] args)
        {

            void swop(ref double xx, ref double yy)
            {
                double zamiana = xx; xx = yy; yy = zamiana;
            }
            int k;

            Console.WriteLine("Podaj liczbe zajec");
            k = Convert.ToInt32(Console.ReadLine());

            double[] s = new double[k];
            double[] f = new double[k];
            double[] numer = new double[k];

            int i;

            for (i = 0; i < k; i++)
            {
                Console.WriteLine("Podaj poczatek zajec  {0}", i);
                s[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj koniec zajec  {0}", i);
                f[i] = Convert.ToInt32(Console.ReadLine());
                numer[i] = i;
            }

            int j;

           

            for (i = 1; i < k; i++)
            {
                for (j = k - 1; j >= i; j--)
                {
                    if (f[j] < f[j - 1])
                    {
                     
                        swop(ref s[j], ref s[j - 1]);
                        swop(ref f[j], ref f[j - 1]);
                        swop(ref numer[j], ref numer[j - 1]);
                    }
                }
            }

            Console.WriteLine("Zaplanowane zajecia");
            i = 0;
            Console.WriteLine("{0}.Zajecia nr {1} start:{2},koniec{3}", i + 1, numer[i], s[i], f[i]);
            j = 0;

            for (int ij = 1; ij < k; ij++)
            {
                if (s[ij] >= f[j])
                {
                    i++;
                    Console.WriteLine("{0}.Zajecia nr {1} start:{2},koniec{3}", i + 1, numer[ij], s[ij], f[ij]);
                    j = ij;
                }
            }

            Console.ReadKey();

        }
    }
}
