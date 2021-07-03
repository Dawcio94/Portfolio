using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{

    class K<T>
    {
        T x ;
        public K(T p){
            x=p;
            }

        public void wypisz()
        {
            Console.WriteLine(x);
        }
}


    class Program
    {
        static void Main(string[] args)
        {

            void zamiana<T>(ref T a, ref T b)
            {
                T c;
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine("Podaj pierwsza liczbe");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            int b1 = int.Parse(Console.ReadLine());

            zamiana(ref a1, ref b1);

            Console.WriteLine("Liczby po zamianie:" + a1 + " " + b1);

            Console.WriteLine("Podaj pierwszy wyraz");
            string s1 = Console.ReadLine() + " ";
            Console.WriteLine("Podaj drugi wyraz");
            string s2 = Console.ReadLine();

            Console.WriteLine(s1 + s2);

            zamiana(ref s1, ref s2);

            Console.WriteLine(s1 + s2);

            Console.WriteLine("Podaj dowolne wyrazanie");
            string h1 = Console.ReadLine() + " ";
            K<string> nowa = new K<string>(h1);
            nowa.wypisz();




            Console.ReadLine();
        }
    }
}
