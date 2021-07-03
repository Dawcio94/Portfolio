using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad64
    {
        public void XY()
        {
            Console.WriteLine("Podaj wspolrzedna X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedna Y");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("I cwiartka");
            else if(x>0 && y<0)
                Console.WriteLine("IV cwiartka");
            else if(x<0 && y<0)
                Console.WriteLine("III cwiartka");
            else
                Console.WriteLine("II cwiartka");


        }
    }
}
