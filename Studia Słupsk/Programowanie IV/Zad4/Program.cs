using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
     public class Program
    {
        static void Main(string[] args)
        {
          
            void Wypisz(string x,string y,int z)
            {
                Console.WriteLine("Imie:" + x);
                Console.WriteLine("Nazwisko:" + y);
                Console.WriteLine("Wiek:" + z);
                Console.WriteLine("******************");
            }

            void Zdejmij (Stack<Osoba> k,ref int n,ref float aver)
            {
                Osoba m = k.Peek();
                Wypisz(m.im,m.naz, m.wiek);
                aver += m.wiek;
                k.Pop();
                n--;
            }

            Stack<Osoba> ludzie = new Stack<Osoba>();
            Console.WriteLine("Podaj liczbe osob");
            int liczbao = Convert.ToInt32(Console.ReadLine());
            float suma = 0;
            for(int i = 0; i < liczbao; i++)
            {
                Console.WriteLine("Podaj imie");
                string di = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko");
                string dn = Console.ReadLine();
                Console.WriteLine("Podaj wiek");
                int dw = Convert.ToInt32(Console.ReadLine());

                ludzie.Push(new Osoba(di, dn, dw));
            }
            int osoby = liczbao;
            while (liczbao > 0)
            {
                Zdejmij(ludzie, ref liczbao,ref suma);
    
            }
            Console.WriteLine("Srednia wieku:"+(suma/osoby));

            Console.ReadLine();
        }
    }
}
