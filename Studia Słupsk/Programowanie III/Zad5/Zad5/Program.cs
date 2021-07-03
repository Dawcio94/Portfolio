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

            List<BankAccount> list = new List<BankAccount>();

            list.Add(new BankAccount(150.00, 1));
            list.Add(new BankAccount(225.00, 2));

            string str;
                
                do {
                Console.WriteLine("1.Podac stan konta");
                Console.WriteLine("2.Wyciagnij pieniadze z konta");
                Console.WriteLine("3.Zrob przelew");
                Console.WriteLine("4.Exit");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1":

                        Console.WriteLine("Podaj ID konta");
                        int id = int.Parse(Console.ReadLine());

                        foreach (var s in list.Where(x => x.ind == id))
                        {
                            Console.WriteLine("Id konta: " + id + ".Stan konta: " + s.acount.ToString());

                        }

                        continue;
                    case "2":

                        Console.WriteLine("Podaj ID konta");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj kwote ktora chcesz wybrac");
                        double cash = double.Parse(Console.ReadLine());

                        foreach (var s in list.Where(x => x.ind == id))
                        {
                            s.GetCash(cash);
                        }

                        continue;

                    case "3":

                        Console.WriteLine("Podaj ID swojego konta");
                        id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj kwote ktora chcesz przelac");
                        cash = double.Parse(Console.ReadLine());

                        Console.WriteLine("Podaj ID drugiego konta");
                        int fid = int.Parse(Console.ReadLine());

                        foreach (var s in list.Where(x => x.ind == id))
                        {
                           BankAccount first = s;
                            foreach (var t in list.Where(x => x.ind == fid))
                            {
                               BankAccount second = t;
                                first.Transfer(second, cash);
                            }
                            
                        }

                        continue;
                }
        } while (str != "Exit");

            Console.ReadKey();
        }
    }
}


