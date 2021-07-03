using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad65
    {
        public void Word()
        {
            Console.WriteLine("Podaj liczbe zeby zamienic ją na słowo");
            int n=int .Parse(Console.ReadLine());
            switch(n){
                case 1:
                    Console.WriteLine("Jeden");
                    break;
                case 2:
                    Console.WriteLine("Dwa");
                    break;
                case 3:
                    Console.WriteLine("Trzy");
                    break;
                default:
                    Console.WriteLine("Cos poszlo nie tak :)");
                    break;

            }
        }
    }
}
