using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wyraz A");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj wyraz B");
            string b = Console.ReadLine();

            a = '@'+ a;
            b = '@'+ b;

            int n = a.Length;
            int k = b.Length;

            int[,] p = new int[n,k];

            for (int i=1;i<k;i++)
            {
                for (int j=1;j<n;j++)
                {
                    if (a[i] == b[j])
                    {
                        p[(i - 1),(j - 1)]++;
                    }
                    else
                    {
                        if (p[i, j - 1] > p[i - 1, j])
                        {
                            p[i, j] = p[i, j - 1];
                        }
                        else
                        {
                            p[i, j] = p[i - 1, j];
                        }
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(p[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
