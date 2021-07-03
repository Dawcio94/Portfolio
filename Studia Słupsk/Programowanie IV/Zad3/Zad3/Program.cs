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
            string imi, nazw;
            int wi;
                void wypisz(string x, string y, int z)
                {
                    Console.WriteLine("Imię: " + x);
                    Console.WriteLine("Nazwisko: " + y);
                    Console.WriteLine("Wiek: " + z);

                }
                
                List<Osoba> ludzie = new List<Osoba>();
            List<Osoba> pytanie = new List<Osoba>();
            
            
                Console.WriteLine("Ile osób");
                int o = int.Parse(Console.ReadLine());
                int i;
                for (i = 1; i <= o; i++)
                {
                    Console.WriteLine("Imię: ");
                    imi = Console.ReadLine();
                    Console.WriteLine("Nazwisko: ");
                    nazw = Console.ReadLine();
                    Console.WriteLine("Wiek: ");
                    wi = int.Parse(Console.ReadLine());
                    ludzie.Add(new Osoba(imi, nazw, wi));

                }

            Console.WriteLine("Osoba dodatkowa");
            Console.WriteLine("Imię: ");
            imi = Console.ReadLine();
            Console.WriteLine("Nazwisko: ");
             nazw = Console.ReadLine();
            Console.WriteLine("Wiek: ");
            wi = int.Parse(Console.ReadLine());

            

            ludzie.Insert(1, new Osoba(imi, nazw, wi));

            //pytanie = ludzie.FindAll(zmienna => zmienna.wiek < 80);
            pytanie = ludzie.FindAll(zmienna => zmienna.naz[0] == 'N');


            for (i = 0; i < ludzie.Count; i++)
            {
                Console.WriteLine("Osoba " + i);
               wypisz(ludzie[i].im , ludzie[i].naz,ludzie[i].wiek);
            }
            Console.WriteLine("******************");
            for (i = 0; i < pytanie.Count; i++)
            {
                Console.WriteLine("Osoba " + i);
                wypisz(pytanie[i].im, pytanie[i].naz, pytanie[i].wiek);
            }

            Console.ReadLine();
            }
        }
    }
