using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad45
    {
        public void Person1()
        {
            const double maxGrade = 100;
            Console.WriteLine("Podaj imie studenta");
            string firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko studenta");
            string lastName = Console.ReadLine();
            Console.WriteLine("Podaj ilosc zdobytych pkt przez studenta");
            string points = Console.ReadLine();

            double grade =double.Parse(points);
            double perc = grade / maxGrade;
            string name = firstName + " " + lastName;
            Console.WriteLine($"{name,-30}{perc:p}");
        }
    }
}
