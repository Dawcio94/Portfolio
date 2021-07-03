using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad66
    {
        public void Week()
        {
            Console.WriteLine("Podaj któryś z kolei dzien tygodnia");
            ConsoleKeyInfo kl=Console.ReadKey();
            Console.WriteLine();
            switch (kl.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Wtorek");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Środa");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Czwartek");
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Piątek");
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Sobota");
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;

            }
        }
    }
}
