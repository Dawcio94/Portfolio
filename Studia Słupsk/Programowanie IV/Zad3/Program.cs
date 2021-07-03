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
            Stack<int> liczby = new Stack<int>();
            Random x = new Random();

            Console.WriteLine("Ile elementow na stosie");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Losowane");

            for(int i = 0; i < n; i++)
            {
                int y = x.Next(1, 150);
                liczby.Push(y);
                Console.WriteLine(y);
            }

            Console.WriteLine("LIczba na stosie:" + liczby.Count);
            Console.WriteLine("Max z stosu:" + liczby.Max());

            int []t = new int[n];

            t = liczby.ToArray();

            Array.Sort(t);

            Console.WriteLine("Posortowane");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(t[i]);
            }

            Console.WriteLine("Zdejmowane ze stacka");

            while (liczby.Count > 0)
            {
                Console.WriteLine(liczby.Peek());
                liczby.Pop();
            }



            Console.ReadLine();
        }
    }
}
