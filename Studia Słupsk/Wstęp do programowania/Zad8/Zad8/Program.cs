using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\Dawid\Studia Słupsk\I rok\I semestr\Programowanie\Zad8\Zad8\bin\Debug");
            /*Zad81 zad81 = new Zad81();
            zad81.Number();

            Zad82 zad82 = new Zad82();
            zad82.Plus();

            Zad83 zad83 = new Zad83();
            zad83.Example();

            Zad84 zad84 = new Zad84();
            zad84.Read();

            Console.WriteLine("1.Odczytaj plik");
            Console.WriteLine("2.Zapisz tekst");
            Console.WriteLine("3.Zmien nazwe pliku");
            Console.WriteLine("ESC.Wyjście");
            ConsoleKeyInfo kl;
            kl = Console.ReadKey();
            Zad85 zad85 = new Zad85();
            zad85.Main(kl);

            Zad86 zad86 = new Zad86();
            Console.WriteLine("Podaj nazwe pliku");
            string s = Console.ReadLine();
            s = s + ".txt";
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name != s)
                {
                    Console.WriteLine("Nie ma takiego pliku");
                    break;
                }
                else
                {
                    Console.WriteLine(zad86.Count(s));
                }
            }

            Console.WriteLine("Podaj tekst");
            string st = Console.ReadLine();
            Zad87 zad87 = new Zad87();
            zad87.Text(st);

            string m = di.ToString() + "$";
            Console.Write(m);
            string s = Console.ReadLine();
            Zad88 zad88 = new Zad88();
            zad88.Files(s);*/
            
            Console.WriteLine("1.Wyświetl książki");
            Console.WriteLine("2.Dodaj książkę");
            Console.WriteLine("3.Usuń książkę");
            Console.WriteLine("4.Wyszukaj ksiażkę");
            Console.WriteLine("ESC.Wyjście");
            ConsoleKeyInfo kl;
            kl = Console.ReadKey();

            Zad89 zad89 = new Zad89();
            zad89.CSV(kl);

            Console.ReadKey();
        }
    }
}
