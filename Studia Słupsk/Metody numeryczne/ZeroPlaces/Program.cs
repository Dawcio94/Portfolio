using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlaces
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj lewy koniec przedział");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj prawy prawy przedział");
            double b = int.Parse(Console.ReadLine());

                if (a > b){
                Console.WriteLine("Źle podany przedział.A musi być mniejsze od B");
                 }
                else
                {
                Bisection bisection = new Bisection(a, b);
                bisection.write();
                Falsi falsi = new Falsi(a, b);
                falsi.write();
                Secant secant = new Secant(a, b);
                secant.write();
                Tangent tangent = new Tangent(a);
                tangent.write();
            }

            Console.ReadKey();

        }
    }
}
