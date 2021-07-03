using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad613
    {
        public void Draw()
        {
            Console.WriteLine("Podaj dlugosc boku");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <=n; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("");      
            }
        }
    }
}
