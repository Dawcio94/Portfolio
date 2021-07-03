using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            void swop(ref double xx, ref double yy)
            {
                double zamiana = xx;
                xx = yy;
                yy = zamiana;
            }
            int k;
            int i, j ;
            Console.WriteLine("Podaj ilosc zajec");
            k = int.Parse(Console.ReadLine());

            double[] s = new double[k];
            double[] f = new double[k];
            double[] numer = new double[k];

            for(i = 0; i < k; i++)
            {
                Console.WriteLine("Podaj pocz zaj "+i);
                s[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj kon zaj " + i);
                f[i] = double.Parse(Console.ReadLine());
                numer[i] = i;
            }

            for ( i = 1; i < k; i++) {
                for(j = k - 1; j >= i; j--)
                {
                    if (f[j] < f[j - 1])
                    {
                        swop(ref s[j], ref s[j - 1]);
                        swop(ref f[j], ref f[j - 1]);
                        swop(ref numer[j], ref numer[j - 1]);
                    }
                }
            }
            i = 0; j = 0; ;
            Console.WriteLine("Zaplanowane zajecia");
            Console.WriteLine(i + 1 + ".Zajecia nr " + numer[i] + "Start:" + s[i] + ",koniec:" + f[i]);

            for(int ij = 1; ij < k; ij++)
            {
                if (s[ij] >= f[j]+1)
                {
                    i++;
                    Console.WriteLine(i + 1 + ".Zajecia nr " + numer[ij] + "Start:" + s[ij] + ",koniec:" + f[ij]);
                    j = ij;
                }
            }
            Console.ReadKey();

        }
    }
}
