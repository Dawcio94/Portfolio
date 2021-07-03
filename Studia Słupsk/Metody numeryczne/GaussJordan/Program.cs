using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussJordan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wielkosc ukladu rownan");
            int n = int.Parse(Console.ReadLine());
            //double[,] MacierzA = new double[4, 5];
            double Delta;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= n; j++)
            //    {

            //        if (j == n)
            //        {
            //            Console.WriteLine("Podaj wartosc wyrazu wolnego" + " w rownaniu " + (i + 1));
            //            MacierzA[i, j] = double.Parse(Console.ReadLine());
            //        }
            //        else
            //        {
            //            Console.WriteLine("Podaj wartosc wspolczynnika x" + (j + 1) + " w rownaniu " + (i + 1));
            //            MacierzA[i, j] = double.Parse(Console.ReadLine());
            //        }
            //    }
            //}

           double[,] MacierzA = new double[4, 5]{
                { 2,2,-1,1,7 },
                { -1,1,2,3,3},
                { 3,-1,4,-1,31 },
                { 1,4,-2,2,2}
            };




            for (int i = 0; i < n-1; i++)
            {

                for (int j = i+1; j < n; j++)
                {
                    Delta = MacierzA[j, i] / MacierzA[i, i];
                    for (int k = i; k < n + 1; k++)
                    {
                        
                        MacierzA[j, k] = MacierzA[j, k] - (Delta * MacierzA[i,k]);
                    }
                }
            }

            Delta = 0;
            for (int i = n-1; i >= 0; i--)
            {

                for (int j = i - 1; j >= 0; j--)
                {
                    Delta = MacierzA[j, i] / MacierzA[i, i];
                    for (int k = n; k >=0; k--)
                    {
                        MacierzA[j, k] = MacierzA[j, k] - (Delta * MacierzA[i, k]);
                        if(MacierzA[j,k]<0.000000001)
                        {
                            MacierzA[j, k] = 0;
                        }
                     }
                    
                }
            }






            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n + 1; j++)
                {
                    Console.Write(MacierzA[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
