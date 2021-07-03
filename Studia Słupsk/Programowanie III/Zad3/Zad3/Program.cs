using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxvolume = 1000,currentvolume=0;
            List<Box> list = new List<Box>();
            do
            {
                Box box = new Box();
                Console.WriteLine("Podaj szerokosc pudelka");
                box.width = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj glebokosc pudelka");
                box.depth = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokosc pudelka");
                box.height = double.Parse(Console.ReadLine());
                list.Add(box);
                currentvolume += box.GetVolume(box.width, box.height, box.depth);

            } while (currentvolume <= maxvolume);
            Console.WriteLine(currentvolume.ToString());
            foreach(var b in list)
            {
                Console.WriteLine(b);
                
            }
            Console.ReadKey();
        }
    }
}
