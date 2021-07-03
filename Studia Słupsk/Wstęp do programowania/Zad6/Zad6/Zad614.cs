using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad614
    {
        public void Pyramid()
        {
            Console.WriteLine("Podaj wysokosc piramidy");
            int n = int.Parse(Console.ReadLine());
            if (n >= 10)
             {
                 Console.WriteLine("Moze byc trudno"); 
             }
             else
             {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i * 2; k++)
                {
                    Console.Write(i + 1);
                }
                Console.WriteLine();

            }
            }
        }
    }
}
