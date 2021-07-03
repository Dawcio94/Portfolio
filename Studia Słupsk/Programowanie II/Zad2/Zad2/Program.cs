using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj A");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj B");
            int k = int.Parse(Console.ReadLine());
            int NWD(int a,int b)
            {
                if (b==0)
                {
                    return a;
                }
                else
                {
                    return NWD(b, a%b);
                }
            }
            Console.WriteLine("NWD A i B="+NWD(n, k));
            Console.ReadKey();
        }
       
    }
}
