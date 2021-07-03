using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad612
    {
        
        public void Fibo()
        {
            int a = 0,c = 1,t;
            Console.WriteLine("Podaj liczbe do obliczenia danego wyrazu Ciagu Fibonnaciego:");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            for (int i = 0; i < f; i++)
                {
                    Console.WriteLine(c);
                    c += a;
                    a = c - a;
                }
        }
        public void Fibover2()
        {
            int a = 0, c = 1, t;
            Console.WriteLine("Podaj liczbe do obliczenia danego wyrazu Ciagu Fibonnaciego:");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            for (int i = 0; i < f-1; i++)
            {
                Console.WriteLine(c);
                c += a;
                a = c - a;
            }
        }
    }
}
