using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tab = new List<int>();
            try {
                int counter = 0;
                int liczydlo = 1;
                int k=2,p;
                string[] lines = File.ReadAllLines("plik.txt");
                int n = int.Parse(lines[0]);
                if (n != lines.Length)
                {
                    throw new Error();
                    
                }
                for(int i = 1; i <= n; i++)
                {
                    int x = int.Parse(lines[i]);
                    for(int j = 1; j <= x; j++)
                    {
                        if (x % j == 0)
                        {
                            counter++;
                        }
                        else
                        {
                        }
                    }
                    p = 2;
                    while (k % p != 0)
                    {
                        p++;
                    }
                    if (k == p)
                    {
                        liczydlo++;
                    }
                    
                    
                        tab.Add(counter * x + liczydlo);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Nie znaleziono pliku");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Chyba gdzies tam jest tekst w danych :)");
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }

            for (int m = 0; m < tab.Count; m++)
            {
                Console.WriteLine(tab[m]);
            }
            Console.ReadKey();
            }
    }
}
