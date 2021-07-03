using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public delegate void Ciag(double a0, double h, int n);
    public class Ciagi
    {
        public void Aryt(double a, double r, int n)
        {
            List<double> aryt = new List<double>();
            aryt.Add(a);
            for (int i = 1; i < n; i++)
            {
                aryt.Add(aryt[i - 1] + r);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(aryt[i] + " ");
            }
            Console.WriteLine();
        }
        public void Geo(double a, double q, int n)
        {
            List<double> geo = new List<double>();
            geo.Add(a);
            for (int i = 1; i < n; i++)
            {
                geo.Add(geo[i - 1] * q);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(geo[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a0r, r, a0g, q;
            Ciagi ciagi = new Ciagi();
            //Console.WriteLine("Podaj liczbe wyrazow ciagu");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj a0 dla ciagu arytmetycznego");
            //a0r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj roznice dla ciagu arytmetycznego");
            //r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj a0 dla ciagu geometrycznego");
            // a0g = double.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj iloraz dla ciagu geometrycznego");
            // q = double.Parse(Console.ReadLine());

            //Ciag ciagar = new Ciag(ciagi.Aryt);
            //ciagar(a0r, r, n);
            //Console.WriteLine();
            //Ciag ciaggeo = new Ciag(ciagi.Geo);
            //ciaggeo(a0g, q, n);

            Console.WriteLine("Wybierz rodzaj ciagu");
            Console.WriteLine("1.Ciag arytmetyczny");
            Console.WriteLine("2.Ciag geometyczny");
            int ch = int.Parse(Console.ReadLine());

            Ciag ciag = new Ciag(ciagi.Aryt);
            Random rnd = new Random();
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Podaj liczbe wyrazow ciagu");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj a0 dla ciagu arytmetycznego");
                    a0r = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj roznice dla ciagu arytmetycznego");
                    r = double.Parse(Console.ReadLine());
                    ciag(a0r, r, n);
                    Console.WriteLine("**********");
                    ciag += ciagi.Geo;
                    ciag(a0r, r, rnd.Next(1, 4));
                    break;
                case 2:
                    ciag += ciagi.Geo;
                    ciag -= ciagi.Aryt;
                    Console.WriteLine("Podaj liczbe wyrazow ciagu");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj a0 dla ciagu geometrycznego");
                    a0g = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj iloraz dla ciagu geometrycznego");
                    q = double.Parse(Console.ReadLine());
                    ciag(a0g, q, n);
                    Console.WriteLine("**********");
                    ciag += ciagi.Aryt;
                    ciag(a0g, q, rnd.Next(1, 4));
                    break;
            }
        Console.ReadKey();
        } 
    }
}
