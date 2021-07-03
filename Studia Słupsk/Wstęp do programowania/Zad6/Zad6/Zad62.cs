using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad62
    {
        public void Compare1()
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            double d = double.Parse(Console.ReadLine());
            bool r = Math.Abs(c - d )< 0.00001;
            if (r == true)
                Console.WriteLine("Sa rowne");
            else if (c > d)
                Console.WriteLine(c);
            else
                Console.WriteLine(d);


        }
    }
}
