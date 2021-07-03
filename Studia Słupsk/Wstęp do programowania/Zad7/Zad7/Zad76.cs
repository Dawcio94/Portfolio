using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Zad76
    {
        public void Matrix(int ka,int wa,int kb,int wb)
        {
            if(wa==kb)
            {
                int[,] mata = new int[wa, ka];
                int[,] matb = new int[wb, kb];
                int[,] matc = new int[wa, kb];
                for(int i = 0; i < wa; i++)
                {
                    for(int j = 0; j < ka; j++)
                    {
                        Console.WriteLine("Podaj wartosc macierzy A o indeksie{0}{1}", i, j );
                        mata[i,j]=int.Parse(Console.ReadLine());
                    }
                }
                for (int i = 0; i < wb; i++)
                {
                    for (int j = 0; j < kb; j++)
                    {
                        Console.WriteLine("Podaj wartosc macierzy B o indeksie{0}{1}", i , j );
                        matb[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < wa; i++)
                {
                    for (int j = 0; j < kb; j++)
                    {
                        matc[i, j] = 0;
                        for (int l = 0; l < ka; l++)
                        {
                            matc[i, j] += (mata[i, l] * matb[l, j]);
                            
                        }
                    } 
                }
               for (int i = 0; i < wa; i++)
                {
                    for (int j = 0; j < kb; j++)
                    {
                        Console.Write(matc[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Liczba kolumn A musi byc rowna liczbie wierszy B i odwrotnie");

            }
        }
        public void Matrixs(int ka, int wa, int kb, int wb)
        {
            if (wa == kb)
            {
                int[,] mata = new int[wa, ka];
                int[,] matb = new int[wb, kb];
                int[] matc = new int[wa*ka];
                int[] matd = new int[wb * kb];
                int[] matw = new int[wa*kb];
                int k = 0;

                for (int i = 0; i < wa; i++)
                    {
                        for (int j = 0; j < ka; j++)
                        {
                            Console.WriteLine("Podaj wartosc macierzy A o indeksie{0}{1}", i, j);
                            mata[i, j] = int.Parse(Console.ReadLine());
                          
                        }
                    }
                
                for (int i = 0; i < wa; i++)
                {
                    for (int j = 0; j < ka; j++)
                    { 
                            matc[k] = mata[i, j];
                            k++;
                    }
                }
                for (int i = 0; i < wb; i++)
                {
                    for (int j = 0; j < kb; j++)
                    {
                        Console.WriteLine("Podaj wartosc macierzy B o indeksie{0}{1}", i, j);
                        matb[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                k = 0;
                for (int i = 0; i < kb; i++)
                {
                    for (int j = 0; j < wb; j++)
                    {
                        matd[k] = matb[j, i];
                        k++;
                    }
                }


               k = 0;
                for (int i = 0; i <wa; i++)
                {
                    for (int j = 0; j < wa; j++)
                    {
                        for (int l = 0; l <ka; l++) {
                            matw[k] += (matc[(3 * j) + l] * matd[l + (3 * i)]);
                        }
                        k++;
                    }
                    
                }

                for(int i = 0; i < wa * kb; i++)
                {
                    Console.Write(matw[i]);
                }
            }
            else
            {
                Console.WriteLine("Liczba kolumn A musi byc rowna liczbie wierszy B i odwrotnie");

            }
        }
    }
}
