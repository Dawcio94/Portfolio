using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> onp = new Stack<int>();
            Stack<int> result = new Stack<int>();
            string w, pomoc;
            int liczenie = 0, i = 0, a, b, j;

            Console.WriteLine("Podaj wyrazenie");
            w = Console.ReadLine();

            while (i < w.Length)
            {
                if (w[i] != ' ')
                {
                        if (w[i] < '0' || w[i] > '9')
                        {
                            a = onp.Pop();
                            b = onp.Pop();
                            switch (w[i])
                            {
                                case '+':
                                    liczenie = a + b;
                                i++;
                                result.Push(liczenie);
                                continue;
                                case '*':
                                    liczenie = a * b;
                                i++;
                                result.Push(liczenie);
                                continue;
                                case '-':
                                    liczenie = b - a;
                                i++;
                                result.Push(liczenie);
                                continue;
                                case '/':
                                    liczenie = b / a;
                                i++;
                                result.Push(liczenie);
                                continue;
                            }
                        }
                        else
                        {
                            j = i;
                            pomoc = "";
                            while (w[j] >= '0' && w[j] <= '9')
                            {
                                pomoc += w[j];
                                j++;
                            }
                            liczenie = Convert.ToInt32(pomoc);
                            onp.Push(liczenie);
                            i = j;
                        }
                    
                }
                else
                {
                    i++;
                }
            }
            int suma = 0;
            while (result.Count>0)
            {
                
                suma+= result.Pop();
            }
            Console.WriteLine("Wynik:" + suma);
            Console.ReadKey();
        }
    }
 }
