using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
   public  class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj numer poczatkowy");
            int nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Klasa Glowna");
            Glowna g = new Glowna();
            Console.WriteLine(g.W(nr));
            Console.WriteLine("Klasa Jeden");
            /*Jeden j = new Jeden();
            Console.WriteLine(j.W(nr));
            Console.WriteLine("Klasa Dwa");
            Dwa d = new Dwa();
            Console.WriteLine(d.W(nr));
            

            Iwyr gj = g as Iwyr;
            Console.WriteLine(gj.W(nr));

    */

            Console.ReadLine();
        }
    }
}
