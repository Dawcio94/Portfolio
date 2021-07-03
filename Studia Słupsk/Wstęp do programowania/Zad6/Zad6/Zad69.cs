using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad69
    {
        public void Summidver2()
        {
            float c = 0,n,suma=0,sr;
            List<float> list = new List<float>();
            
            Console.WriteLine("Podaj ilosc wartosci");
            n = float.Parse(Console.ReadLine());
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine("Podaj " + (i + 1)+" wartosc");
                list.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in list)
            {
                suma += item;
                c++;
            }
            sr = suma / c;
            Console.Write("Suma wynosi " + suma+" a srednia rowna sie:"+sr); 
        }
    }
}

