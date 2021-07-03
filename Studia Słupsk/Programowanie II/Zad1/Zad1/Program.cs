using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj k");
            int k = int.Parse(Console.ReadLine());
            int Ciag(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else if(n==2 || n == 3)
                {
                    return 2;
                }
                else
                {
                    return Ciag(n - 1) + Ciag(n - 3);
                    
                }
            }
            for(int i = 1; i <= k; i++)
            {
                Console.WriteLine((Ciag(i)).ToString());
            }
            

            Console.ReadKey();
        }
    }
}
