using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {      
            float wynik = 1;
            Console.WriteLine("Podaj k");
           
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                for (int i = 2; i <=n;i++) {
                    wynik = wynik / i;
                }
            }
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
        }
}
