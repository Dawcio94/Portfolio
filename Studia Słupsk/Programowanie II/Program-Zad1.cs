using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            void swopw(ref int xx, ref int yy)
            { int zamiana = xx; xx = yy; yy = zamiana; }

            Console.WriteLine("Podaj ilosc wyrazow ciagu n");
            int n = int.Parse(Console.ReadLine());

            int[] ciag=new int[n];

            for (int i = 0; i < n;i++)
            {
                Console.WriteLine("Podaj {0} wyraz ciagu n", i + 1);
                ciag[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Podaj wartosc liczby k");
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    if (ciag[j] <ciag[j - 1])
                    {
                        swopw(ref ciag[j], ref ciag[j - 1]);
                    }
                }
            }
            int max = ciag[n-1];

            Console.WriteLine(max);
            int suma = 0;

            do
            {
                suma += max;
            } while (suma > k);

            Console.WriteLine("Najwieksza mozliwa suma={0}", suma);

            Console.ReadKey();
        }
    }
}
