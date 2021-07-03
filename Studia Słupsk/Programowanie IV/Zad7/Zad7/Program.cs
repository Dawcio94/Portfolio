using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wspolrzedne x p1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedne y p1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedne x p2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedne y p2");
            double y2 = double.Parse(Console.ReadLine());

            Point p1 = new Point (x1, y1);
            Point p2 = new Point(x2, y2);

            Console.WriteLine(p1);

            Console.WriteLine("Punkt po dodaniu:"+(p1 + p2));

            Console.WriteLine("Punkt po ikrementacji"+(p1++));

            if (p1 == p2) {
                Console.WriteLine("Rowne");
                    }
            else
            {
                Console.WriteLine("Rozne");
            }

            if (p1 > p2)
            {
                Console.WriteLine("P1 wieksze od P2");
            }
            else
            {
                Console.WriteLine("P1 mniejsze od P2");
            }

            if (p1 >= p2)
            {
                Console.WriteLine("P1 jest wieksze badz rowne P2");
            }
            else
            {
                Console.WriteLine("P1 jest mniejsze badz rowne P2");
            }
            Console.ReadKey();
        }
    }
}
