using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Podaj wartość koncowa ciagu Fibo");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Zad71 zad71 = new Zad71();
            list=zad71.Fibo(n);
            foreach (int a in list)
            {
                Console.WriteLine(a);
            }

            Zad72 zad72 = new Zad72();
            Console.Write(zad72.Geo());
            
            Console.WriteLine("Podaj wartość koncowa tablicy");
            int n = int.Parse(Console.ReadLine());
            double[] data = new double[n];
            Zad73 zad73 = new Zad73();
            data = zad73.Ran(n);
            foreach (int a in data)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Podaj wartość koncowa tablicy");
            int n = int.Parse(Console.ReadLine());
            List<double> lists = new List<double>();
            List<double> listss = new List<double>();
            Zad74 zad74 = new Zad74();
            zad74.Modulo(n,out lists,out listss);
            Console.WriteLine("Nieparzyste");
            foreach (int a in lists)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Parzyste");
            foreach (int a in listss)
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine("Podaj rozmiar macierzy");
            int n = int.Parse(Console.ReadLine());
            double[,] taba = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine("Podaj wartosc elementu macierzy A o indeksie ["+(i + 1)+ "]["+ (j + 1)+ "]");
                    taba[i,j]=double.Parse(Console.ReadLine());

                }
            }
            Zad75 zad75 = new Zad75();
            Console.WriteLine("Wyznacznik macierzy: "+zad75.Determ(taba, n));
            */
            Console.WriteLine("Podaj rozmiar macierzy A");
            Console.WriteLine("Podaj ilość kolumn");
            int ka = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość wierszy");
            int wa = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj rozmiar macierzy B");
            Console.WriteLine("Podaj ilość kolumn");
            int kb = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilość wierszy");
            int wb = int.Parse(Console.ReadLine());
            Zad76 zad76 = new Zad76();
            //zad76.Matrix(ka,wa,kb,wb);
            zad76.Matrixs(ka, wa, kb, wb);
            Console.ReadKey();
           /* Console.WriteLine("1.Wyświetl książki");
            Console.WriteLine("2.Dodaj książkę");
            Console.WriteLine("3.Usuń książkę");
            Console.WriteLine("4.Wyszukaj ksiażkę");
            Console.WriteLine("ESC.Wyjście");
            ConsoleKeyInfo kl;
            kl = Console.ReadKey();
            Zad77 zad77 = new Zad77();
            zad77.Library(kl);*/
        }
    }
}
