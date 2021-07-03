using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad63
    {
        public void Under()
        {
            Console.WriteLine("Podaj liczbe");
            float u = float.Parse(Console.ReadLine());
            if (u < 0)
                Console.WriteLine("Jest ujemna");
            else
                Console.WriteLine("Jest dodatnia");
        }
    }
}
