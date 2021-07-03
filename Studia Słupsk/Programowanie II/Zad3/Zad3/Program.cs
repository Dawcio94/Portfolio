using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj X");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj k");
            int b = int.Parse(Console.ReadLine());
            int Potega(int x,int k)
            {
                if (x == 0)
                {
                    return 0;
                }
                else if (k == 0)
                {
                    return 1;
                }
                else if (k == 1)
                {
                    return x;
                }
                else if(k%2==0)
                {
                    return (Potega(x, k / 2) * Potega(x, k / 2));
                }
                else
                {
                    return (Potega(x, (k-1) / 2) * Potega(x, (k-1) / 2)*x);
                }
            }
            Console.WriteLine("X do potegi k="+Potega(a, b));
            Console.ReadKey();
        }
    }
}
