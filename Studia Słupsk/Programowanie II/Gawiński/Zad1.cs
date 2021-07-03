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
            Console.WriteLine("Podaj n");
            int a = int.Parse(Console.ReadLine());

            int Ciag(int n)
            {
                if (n < 1)
                {
                    return -1;
                }
                else
                {
                    if (n == 1 || n == 2 || n == 3)
                    {
                        return 1;
                    }
                    else
                    {
                        return Ciag(n - 1) + Ciag(n - 3) - Ciag(n - 2);
                    }
                }
            }

            Console.WriteLine("N=ty wyraz ciagu = "+Ciag(a).ToString());
            Console.ReadKey();
        }
    }
}
