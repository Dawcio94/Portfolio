using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad68
    {
        public void Summid()
        {
           float a, b, c=1,suma=0;
            float sr;

            Console.WriteLine("Podaj lewa strone zakresu");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj prawa strone zakresu");
            b = float.Parse(Console.ReadLine());
            if (a < b)
            {
                suma = a;
                for(float i = a+1; i <= b; i++)
                {
                    ++c;
                    suma +=i;
                    
                }
                sr = suma / c;
                Console.WriteLine("Suma rowna sie:" + suma + "a srednia rowna sie:" + sr);
            }
            else
            {
                suma = a;
                for (float i = a - 1; i >= b; i--)
                {
                    ++c;
                    suma += i;

                }
                sr = suma / c;
                Console.WriteLine("Suma rowna sie:" + suma + "a srednia rowna sie:" + sr);
            }
        }
    }
}
