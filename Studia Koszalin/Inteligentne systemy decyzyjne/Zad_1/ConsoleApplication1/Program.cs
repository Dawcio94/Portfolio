using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] taball = new int[10,10,10];
            int[,] tfn = new int[10,4];
            double[] vectorTfn = new double[10];
            double[] vectorequals = new double[10];

            Random rnd = new Random();
            int t0=0, t1=0, t2=0, t3=0;
            for(int k = 0; k < 10; k++)
            {
                t0 = 0; t1 = 0; t2 = 0; t3 = 0;
                Console.WriteLine("Macierz{0}",k);
                for (int i = 0; i < 10; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        taball[k,i,j] =rnd.Next(0,21);
                        if (taball[k, i, j] == 5)
                        {
                            t0+=1;
                        }
                        if (taball[k, i, j] == 10)
                        {
                            t1 += 1;
                        }
                        if (taball[k, i, j] == 15)
                        {
                            t2 += 1;
                        }
                                
                        if (taball[k, i, j] == 20)
                        {
                            t3 += 1;
                        }
                        Console.Write(taball[k, i, j] + " ");
                        tfn[k, 0] = t0;
                        tfn[k, 1] = t1;
                        tfn[k, 2] = t2;
                        tfn[k, 3] = t3;
                    }
                    Console.WriteLine("");  
                }
                vectorTfn[k] = Math.Sqrt((Math.Pow(tfn[k, 0], 2)) + (Math.Pow(tfn[k, 1], 2)) + (Math.Pow(tfn[k, 2], 2)) + (Math.Pow(tfn[k, 3], 2)));
                      
            }
            Console.Write("Macierz TFN");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(tfn[i, j]+" ");
                    
                }
               
            }
            
            Console.WriteLine("");
            Console.WriteLine("Porównanie:");
            for(int i = 0; i < 10; i++)
            {
                vectorequals[i] = Math.Round((((tfn[i, 0] * tfn[0, 0]) + (tfn[i, 1] * tfn[0, 1]) + (tfn[i, 2] * tfn[0, 2]) + (tfn[i, 3] * tfn[0, 3])) / (vectorTfn[i] * vectorTfn[0])),3);
                Console.WriteLine(vectorequals[i]);
            }
            Console.ReadKey();
        }
    }
}
