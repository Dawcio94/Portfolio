using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe elementow tablicy");
            int n = int.Parse(Console.ReadLine());

            GTab<int> array = new GTab<int>(n);

            GTab<char> chary = new GTab<char>(n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartosc elementu o indeksie" + (i + 1));
                int y = int.Parse(Console.ReadLine());
                array.Ustaw(i, y);
               
                chary.Ustaw(i, (char)(i + 69));
            }
           
            Console.WriteLine("Elementy tablicy");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array.Wypisz(i)); 
            }

            Console.WriteLine("Elementy tablicy Ascii");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(chary.Wypisz(i));
            }

            
            Console.ReadKey();


        }
    }
}
