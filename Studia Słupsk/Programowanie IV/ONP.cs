using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> onp = new Stack<int>();
            string w,pomoc;
            int liczenie=0,i=0,a,b,j;

            Console.WriteLine("Podaj wyrazenie(Koniec to znak =");
            w = Console.ReadLine();

            while (i < w.Length)
            {
                if(w[i] !=' ')
                {
                    if(w[i] == '=')
                    {
                        Console.WriteLine("Wynikiem wyrazenia jest " + onp.Peek());
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        if (w[i] < '0' || w[i] > '9')
                        {
                            a = onp.Pop();
                            b = onp.Pop();
                            switch (w[i])
                            {
                                case '+':
                                    liczenie = a + b;
                                    break;
                                case '*':
                                    liczenie = a * b;
                                    break;
                                case '-':
                                    liczenie = b - a;
                                    break;
                                case '/':
                                    liczenie = b / a;
                                    break;
                            }
                            onp.Push(liczenie);
                            i++;
                        }
                        else
                        {
                            j = i;
                            pomoc = "";
                            while(w[j]>='0' && w[j] <= '9')
                            {
                                pomoc += w[j];
                                j++;
                            }
                            liczenie = Convert.ToInt32(pomoc);
                            onp.Push(liczenie);
                            i = j;
                        }
                    }
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
