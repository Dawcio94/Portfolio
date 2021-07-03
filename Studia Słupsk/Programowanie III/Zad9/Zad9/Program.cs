using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad9
{
    public abstract class Person
    {
        public abstract string firstname { get; set; }
        public abstract string lastname { get; set; }
        public abstract uint id { get; set; }
        public abstract string adres { get; set; }

        public override string ToString()
        {
            return "Stanowisko:" + GetType().Name + " Imie:" + firstname + " Nazwisko:" + lastname + " ID:" + id + "Adres:" + adres;
        }
    }

    public class Employee : Person
    {
        public double cash { get; set; }
        public override string firstname { get; set; }
        public override string lastname { get; set; }
        public override uint id { get; set; }
        public override string adres { get; set; }

        public override string ToString()
        {
            return "Stanowisko:" + GetType().Name + " Imie:" + firstname + " Nazwisko:" + lastname + " ID:" + id + "Adres:" + adres+"Zarobki:"+cash;
        }
    }

    public class Guest : Person
    {
        public override string firstname { get; set; }
        public override string lastname { get; set; }
        public override uint id { get; set; }
        public override string adres { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            return "Stanowisko:" + GetType().Name + " Imie:" + firstname + " Nazwisko:" + lastname + " ID:" + id + "Adres:" + adres+"Data wyjazdu:"+date;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> company = new List<Person>();
            Person employee1 = new Employee()
            {
                firstname = "Dawid",
                lastname = "Gawinski",
                id = 1,
                adres = "ul.Kolejowa 1/2,76-201 Daleka Wola",
                cash = 2400.20
            };

            Person employee2 = new Employee()
            {
                firstname = "Sandra",
                lastname = "Groszek",
                id = 2,
                adres = "Niskie Doły 3, 76-201 Daleka Wola",
                cash = 2250.00
            };

            Person guest = new Guest()
            {
                firstname = "Alicja",
                lastname = "Jaskółka",
                id = 1,
                adres = "ul.Legionow Polskich 356/12, 50-401 Katowice",
                date = DateTime.Now.Add(new TimeSpan(3, 0, 0, 0))
            };

            company.Add(employee1);
            company.Add(employee2);
            company.Add(guest);

            foreach (var s in company)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
