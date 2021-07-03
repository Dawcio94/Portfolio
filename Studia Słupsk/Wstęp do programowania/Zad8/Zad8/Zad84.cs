using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Zad84
    {
        string s;
        DirectoryInfo di = new DirectoryInfo(@"D:\Dawid\Studia Słupsk\I rok\I semestr\Programowanie\Zad8\Zad8\bin\Debug");
        public void Read()
        {
            
                Console.WriteLine("Podaj nazwe pliku");
                string n = Console.ReadLine();
                 n = n + ".txt";
                foreach (var fi in di.GetFiles())
                {
                    if (fi.Name == n)
                    {
                    using (StreamReader sr = new StreamReader(n))
                    {
                        s = sr.ReadToEnd();
                        Console.Write(s);
                    }
                    break;
                    }
                    else
                    {
                        Console.Write("Nie ma takiego pliku!!");
                    break;
                    }
                }
        }
    }
}