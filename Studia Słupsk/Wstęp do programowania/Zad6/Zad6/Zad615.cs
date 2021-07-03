using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad615
    {
        public void Card()
        {
            Console.WriteLine("Podaj szerokość Karo");
            int n = int.Parse(Console.ReadLine());
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n - y; x++)
                    Console.Write( " ");
                Console.Write("#");
                for (int x = 0; x < y * 2; x++)
                    Console.Write(" ");
                Console.Write("#\n");
            }

            for (int y = n - 1; y >= 0; y--)
            {
                for (int x = 0; x < n - y; x++)
                    Console.Write(" ");
                Console.Write("#");
                for (int x = 0; x < y * 2; x++)
                    Console.Write(" ");
                Console.Write("#\n");
            }
        }
    }
}
