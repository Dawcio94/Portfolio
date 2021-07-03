using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] counterArray = new double[10];
            double[,] tfm = new double[10, 10];
            
            string[] word = new string[10];
            double[] d = new double[10];
            double[] max = new double[10];
            double[] manhattan = new double[10];
            double[] mi = new double[10];

            double suma = 0;
            double absolut = 0;
            double suma1 = 0;
            double suma2 = 0;
            double p = 0;
            double r = 0;

            string word0 = "informatyka";
            string word1 = "matematyka";
            string word2 = "c++";
            string word3 = "komputer";
            string word4 = "motywacja";
            string word5 = "akademicki";
            string word6 = "tablicy";
            string word7 = "zalety";
            string word8 = "programowanie";
            string word9 = "podsumowanie";

            string d1 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\1.txt");
            string d2 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\2.txt");
            string d3 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\3.txt");
            string d4 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\4.txt");
            string d5 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\5.txt");
            string d6 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\6.txt");
            string d7 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\7.txt");
            string d8 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\8.txt");
            string d9 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\9.txt");
            string d0 = System.IO.File.ReadAllText(@"D:\Dawid\Studia\IV rok\ISD\Artykuły\10.txt");

            string[] words0 = d0.Split(' ', ',', '.', ';');
            string[] words1 = d1.Split(' ', ',', '.', ';');
            string[] words2 = d2.Split(' ', ',', '.', ';');
            string[] words3 = d3.Split(' ', ',', '.', ';');
            string[] words4 = d4.Split(' ', ',', '.', ';');
            string[] words5 = d5.Split(' ', ',', '.', ';');
            string[] words6 = d6.Split(' ', ',', '.', ';');
            string[] words7 = d7.Split(' ', ',', '.', ';');
            string[] words8 = d8.Split(' ', ',', '.', ';');
            string[] words9 = d9.Split(' ', ',', '.', ';');

            word[0] = word0;
            word[1] = word1;
            word[2] = word2;
            word[3] = word3;
            word[4] = word4;
            word[5] = word5;
            word[6] = word6;
            word[7] = word7;
            word[8] = word8;
            word[9] = word9;

            String[][] arrays = {
                words0,
                words1,
                words2,
                words3,
                words4,
                words5,
                words6,
                words7,
                words8,
                words9
            };

            for (int i = 0; i < 10; i++)
            {
                counterArray[i] = 0;
                for (int j = 0; j < 10; j++)
                {
                    tfm[i, j] = 0;
                    
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                int counter = 0;
                for (int k = 0; k < arrays.Length; k++)
                {
                    string[] words = arrays[k];
                    for (int j = 0; j < words.Length; j++)
                    {
                        if (words[j].CompareTo(word[i]) == 0)
                        {
                            counter++;
                            tfm[i, k] = counter;
                        }
                    }
                }
            }
            Console.WriteLine("Macierz TFN");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Tekst nr:{0}\t", i);
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tfm[i, j] + "\t");
                }
                Console.Write("\n");
            }
            
            Console.WriteLine("Podaj p i r");
            p =Convert.ToInt32( Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            double cos = 1 / r;

            for (int i = 0; i < 10; i++)
           {
               for(int j=0; j < 10; j++)
               {
                   suma += Math.Pow((tfm[0, i] - tfm[j, i]), 2);
                    
                   d[i] = Math.Sqrt(suma);
                   
                   max[i] = Math.Max(Math.Abs(tfm[0, i] - tfm[j, i]),max[i]);
                   
                    absolut = Math.Abs(tfm[0, i] - tfm[j, i]);
                   suma1 += absolut;
                   manhattan[i] = suma1;
                    
                    suma2 += Math.Pow((tfm[0, i] - tfm[j, i]), p);
                        mi[i] = Math.Pow(suma2, cos);
                    
                }
                 suma = 0;
                 absolut = 0;
                 suma1 = 0;
                 suma2 = 0;
            }
          /*  Console.WriteLine("Euklides");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" "+ Math.Round(d[i], 3));
            }
            Console.WriteLine("");*/
            if (p % 2 == 0) {
                Console.WriteLine("Potęgowa");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(" " + Math.Round(mi[i],3));
                }
            }
            else
            {
                Console.WriteLine("Współczynnik potęgowy p musi być podzielny przez 2!!");
            }
            /*
            Console.WriteLine("");
            Console.WriteLine("Max");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + Math.Round(max[i], 3));
            }
            
            Console.WriteLine("");
            Console.WriteLine("Manhattan");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + Math.Round(manhattan[i], 3));
            }*/
            Console.ReadKey();
        }
    }
}
