using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad39
    {
        public void Modulo()
        {
            Console.WriteLine("Podaj liczbe do zakresu z lewej strony");
            string l=Console.ReadLine();
            Console.WriteLine("Podaj liczbe do zakresu z prawej strony");
            string r = Console.ReadLine();
            double a = double.Parse(l), b = double.Parse(r);
            if (a >= b)
            {
                Console.WriteLine("Liczby parzyste w podany zakresie to: ");
                for(double i = Convert.ToInt64(a); i >= Convert.ToInt64(b);i--)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(i+" ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Liczby parzyste w podany zakresie to: ");
                for (double i = Convert.ToInt64(a); i <= Convert.ToInt64(b); i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            } 
        }
    }
}
