using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Zad83
    {
        string s;
        public void Serv()
        {
            using (StreamReader sr = new StreamReader("plik.txt"))
            {
                s = sr.ReadLine();
            }
            Console.WriteLine("Podaj tekst");
            string t = Console.ReadLine();
            s = s + t;
            using (StreamWriter sw = new StreamWriter("plik.txt"))
            {
                sw.WriteLine(s);
            }
        }
        public void Example()
        {


            if (File.Exists("plik.txt"))
            {
                Serv();
            }
            else
            {
                Console.WriteLine("Brak pliku");
                using (FileStream fs = new FileStream("plik.txt", FileMode.Create))
                {
                    fs.Dispose();
                }
                Serv();
            }
        }
    }
}
          
