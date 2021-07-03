using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wielkosc ukladu rownan");
            int n = int.Parse(Console.ReadLine());
            double[,] MacierzA = new double[n,n+1];
            double[] MacierzW = new double[n];
            double L = 0;


            for(int i = 0; i < n; i++)
            {
                for(int j=0;j<=n;j++)
                {
                    
                    if (j == n )
                    {
                        Console.WriteLine("Podaj wartosc wyrazu wolnego" + " w rownaniu " + (i + 1));
                        MacierzA[i, j] = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Podaj wartosc wspolczynnika x" + (j + 1) + " w rownaniu " + (i + 1));
                        MacierzA[i, j] = double.Parse(Console.ReadLine());
                    }
                }
            }


            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    L = MacierzA[j, i] / MacierzA[i, i];
                    for(int k = i; k < n + 1; k++)
                    {
                        MacierzA[j, k] = MacierzA[j, k] - L * MacierzA[i, k];
                    }
                }
            }


            for(int i = n - 1; i >= 0; i--)
            {
                L = 0;
                for(int j = i + 1; j < n; j++)
                {
                    L += MacierzA[i, j] * MacierzW[j];
                }
                MacierzW[i]=(MacierzA[i, n] - L) / MacierzA[i, i];
            }


            Console.WriteLine("Wyniki:");
            for (int i = 0; i < n; i++)
            {
 
                    Console.Write("x"+(i+1)+"="+MacierzW[i]+" ");
                
            }


            Console.ReadKey();
        }
    }
}
