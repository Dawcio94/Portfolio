using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Console.WriteLine("Podaj tekst");
            string str = Console.ReadLine();
            Zad51 zad51 = new Zad51();
            zad51.Tekst(str);

            Console.WriteLine("Podaj liczbe do obliczenia kwadratu");
            int n = int.Parse(Console.ReadLine());
            Zad52 zad52 = new Zad52();
            Console.WriteLine("Kwadrat z liczby to:"+zad52.Square(n));
            
            
            Console.WriteLine("Podaj stopnie w Celcjuszach");
            double c = double.Parse(Console.ReadLine());
            
            Zad53 zad53 = new Zad53();
            Console.WriteLine("Stopnie Celcjusza w Farenheicie:"+zad53.Degree(c));*/
            
            Zad54 zad54 = new Zad54();
            zad54.Smthg();
            zad54.Smthg();
            zad54.Smthg();
            Console.WriteLine("Ilosc powtorzen:" + zad54.Smthg());
            
            /*Console.WriteLine("Podaj dlugosc podstawy A");
            double a =double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dlugosc podstawy B");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dlugosc wysokosci");
            double h = double.Parse(Console.ReadLine());

            Zad55 zad55 = new Zad55();
            Console.WriteLine("Pole trapezu to:"+zad55.Pole(a,b,h));
            
            Console.WriteLine("Podaj liczbe do obliczenia silni:");
            int s = int.Parse(Console.ReadLine());
            Zad56 zad56 = new Zad56();
            Console.WriteLine("Silnia z liczby "+s+ "to: "+zad56.Silnia(s));
            
            Console.WriteLine("Podaj liczbe do obliczenia danego wyrazu Ciagu Fibonnaciego:");
            int f = int.Parse(Console.ReadLine());
            Zad57 zad57 = new Zad57();
            Console.WriteLine("Wartosc " + f + "elementu ciagu Fibonnaciego wynosi: " + zad57.Fibo(f));
            
            Console.WriteLine("Podaj stopnie celcjusza");
            double cel = double.Parse(Console.ReadLine()),st;
            Zad58 zad58 = new Zad58();
            zad58.Degree1(cel,out st);
            Console.WriteLine("Stopnie w farenheicie:" + st);
            
            Zad59 zad59 = new Zad59();
            Console.WriteLine("Podaj pierwsza liczbe do zamiany");
            float o = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe do zamiany");
            float t = float.Parse(Console.ReadLine());
            zad59.Change(ref o, ref t);
            Console.WriteLine(o+" " + t);*/

            Console.ReadKey();
        }
    }
}
