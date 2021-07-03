using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Zad85
    {
        string s;
        DirectoryInfo di = new DirectoryInfo(@"D:\Dawid\Studia Słupsk\I rok\I semestr\Programowanie\Zad8\Zad8\bin\Debug");
        public void Text(string n)
        {
                    using (StreamReader sr = new StreamReader(n))
                    {
                        s = sr.ReadToEnd();
                    }
                    Console.WriteLine("\nPodaj tekst\n");
                    string t = Console.ReadLine();
                    s = s + t;
                    using (StreamWriter sw = new StreamWriter(n))
                    {
                        sw.WriteLine(s);
                    }
        }
        public void Read(string n)
        {
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name == n)
                {
                    using (StreamReader sr = new StreamReader(n))
                    {
                        s = sr.ReadToEnd();
                        Console.Write(s+"\n");
                    }
                    break;
                }
                else
                {
                    Console.Write("\nNie ma takiego pliku!!\n");
                    break;
                }
            }
        }
        public void Save(string n)
        {
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name == n)
                {
                    Text(n);
                    break;
                }
                else
                {
                    Console.Write("\nNie ma takiego pliku!!\nUtworzono plik o podanej nazwie");
                    using (FileStream fs = new FileStream(n, FileMode.Create))
                    {
                        fs.Dispose();
                        Text(n);
                    }
                    break;
                }
            }
        }
        public void Change(string n,string l)
        {
            foreach (var fi in di.GetFiles())
            {
                if (fi.Name == n)
                {
                    using (StreamReader sr = new StreamReader(n))
                    {
                        s = sr.ReadToEnd();
                    }
                    using (FileStream fs = new FileStream(l, FileMode.Create))
                    {
                        fs.Dispose();
                    }
                    using (StreamWriter sw = new StreamWriter(l))
                    {

                        sw.WriteLine(s);
                    }
                    File.Delete(n);
                    break;
                }
                else
                {
                    Console.Write("\nCos poszlo nie tak\n");
                    break;
                }
            }
        }
        public void Main(ConsoleKeyInfo kl)
        {
            do
            {
                switch (kl.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nPodaj nazwe pliku\n");
                        string n = Console.ReadLine();
                        n = n + ".txt";
                        Read(n);
                        kl = Console.ReadKey();
                        continue;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nPodaj nazwe pliku\n");
                        string k = Console.ReadLine();
                        k = k + ".txt";
                        Save(k);
                        kl = Console.ReadKey();
                        continue;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nPodaj nazwe pliku\n");
                        string o = Console.ReadLine();
                        o = o + ".txt";
                        Console.WriteLine("\nPodaj nowa nazwe pliku\n");
                        string l = Console.ReadLine();
                        l = l + ".txt";
                        Change(o, l);
                        kl = Console.ReadKey();
                        continue;
                    default:
                        break;
                }
            } while (kl.Key != ConsoleKey.Escape);
        }
    }
}
