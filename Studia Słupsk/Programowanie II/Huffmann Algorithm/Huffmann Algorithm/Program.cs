using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffmann_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //metoda zamieniajaca wartosci czestotliwosci 

            void swopw(ref double xx, ref double yy)
            { double zamiana = xx; xx = yy; yy = zamiana; }

            //metoda zamieniajca kolejnosc liter odpowiednio wraz z zamiana wartosci

            void swopl(ref string xx, ref string yy)
            { string zamiana = xx; xx = yy; yy = zamiana; }

            //Podaje ile liter chcemy podac

            Console.WriteLine("Podaj liczbe liter");
            int k = Convert.ToInt32(Console.ReadLine());
            string[] l = new string[k];
            double[] w = new double[k];

            //Podawanie liter oraz przypisanych konkretnej wartosci czestosci 

            for(int i = 0; i < k; i++)
            {
                Console.WriteLine("Podaj litere");
                l[i] = Console.ReadLine();
                Console.WriteLine("Podaj czestosc podanej litery");
                w[i] = double.Parse(Console.ReadLine());
            }

            //sortowanie wg czestosci liter
            do
            {
                for (int i = 1; i < k; i++)
                {
                    for (int j = k - 1; j >= i; j--)
                    {
                        if (w[j] < w[j - 1])
                        {
                            swopw(ref w[j], ref w[j - 1]);
                            swopl(ref l[j], ref l[j - 1]);
                        }
                    }
                }
                //wyświetlenie rosnacych stworzonych wezlow posortowanych wartosci czestlotliwosci 

                Console.WriteLine("\nPosortowane wezly");

                for (int i = 0; i < k; i++)
                {
                    Console.Write(l[i] + "\t");
                }

                Console.WriteLine();

                for (int i = 0; i < k; i++)
                {
                    Console.Write(w[i] + "\t");
                }

                //sumowanie dwoch najmniejszych wartosci 

                l[0] += "+" + l[1];
                w[0] += w[1];

                Console.WriteLine("\nStworzone nowe wezly");

                for (int i = 1; i < k-1; i++)
                {
                    l[i] = l[i + 1];
                    w[i] = w[i + 1];
                }

                //wyswietlanie stworzone wezly oraz czestotliwosci

                for (int i = 0; i < k - 1; i++)
                {
                    Console.Write(l[i] + "\t");
                }

                Console.WriteLine();

                for (int i = 0; i < k - 1; i++)
                {
                    Console.Write(w[i] + "\t");
                }
                
                k--;
            } while (k != 1);

            Console.ReadKey();

        }
    }
}
