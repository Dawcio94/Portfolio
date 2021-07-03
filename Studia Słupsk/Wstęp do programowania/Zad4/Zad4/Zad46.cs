using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad46
    {
        public void Person2()
        {
            const double maxGrade = 100;
            Console.Write("Podaj imie studenta\n");
            string firstName = Console.ReadLine();
            Console.Write("Podaj nazwisko studenta\n");
            string lastName = Console.ReadLine();
            Console.Write("Podaj ilosc zdobytych pkt przez studenta\n");
            string points = Console.ReadLine();

            double grade = double.Parse(points);
            double perc = grade / maxGrade;
            string name = firstName + " " + lastName;
            Console.Write($"{name,-30}{perc:p}");
        }
    }
}
