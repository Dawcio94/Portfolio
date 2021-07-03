using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Podaj liczbe elementow tablicy");
            int n = int.Parse(Console.ReadLine());

            GTab<int> integ1 = new GTab<int>(n);
            GTab<int> integ2 = new GTab<int>(n);
            GTab<int> char1 = new GTab<int>(n);
            GTab<int> char2 = new GTab<int>(n);

            void zamiana<T>(ref T a, ref T b)
            {
              T c = a;
                a = b;
                b = c;
            }

          

            for (int i = 0; i < n; i++)
            {   
                integ1.Ustaw(i, rand.Next(1, 100));
                integ2.Ustaw(i, rand.Next(1, 100));
                char1.Ustaw(i, rand.Next(97, 122));
                char2.Ustaw(i, rand.Next(97, 122));
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(integ1.Wypisz(i) + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(integ2.Wypisz(i) + "\t");
            }

            Console.WriteLine();
           
            for (int i = 0; i < n; i++)
            {
                Console.Write((char)char1.Wypisz(i) + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write((char)char2.Wypisz(i) + "\t");
            }

            Console.WriteLine("Tablica liczb bo zamianach");
            for (int i = 0; i < n; i++)
            {
                Console.Write(integ1.Wypisz(i) + "\t");
            }
            Console.WriteLine("Tablica charow bo zamianach");

            for (int i = 0; i < n; i++)
            {
                Console.Write((char)char1.Wypisz(i) + "\t");
            }

            for (int i = 0; i < n; i++) {
                zamiana(ref integ1.Wypisz(i), ref  integ2.Wypisz(i));
                    }

            Console.ReadKey();
        }
    }
}
