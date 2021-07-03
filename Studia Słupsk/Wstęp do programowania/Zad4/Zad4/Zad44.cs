using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad44
    {
        public void Person()
        {
            const double maxGrade = 100;
            string firstName = "Jan",lastName="Nowak";
            double grade = 55;
            double perc = grade / maxGrade;
            string name = firstName + " " + lastName;
            Console.WriteLine($"{name,-30}{perc:p}");
        }
    }
}
