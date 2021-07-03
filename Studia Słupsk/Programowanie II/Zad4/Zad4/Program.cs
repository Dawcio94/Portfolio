using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POdaj ilosc krazkow");
            int k = int.Parse(Console.ReadLine());

            void Przenies(char a,char b)
            {
                Console.WriteLine("{0} -> {1}", a, b);
            }

            void Hanoi(int n,char a,char b,char c)
            {
                if (n == 0)
                {
                    Przenies(a, b);
                }
                else
                {
                    Hanoi(n - 1, a, c, b);
                    Przenies(a, b);
                    Hanoi(n - 1, c, b, a);
                }
            }
            Hanoi(k, 'A', 'B', 'C');
            Console.ReadKey();
        }
    }
}
