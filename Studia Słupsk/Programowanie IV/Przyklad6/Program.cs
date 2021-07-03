using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> evens = new List<int>();
            List<int> threes = new List<int>();
            List<int> fives = new List<int>();
            List<int> sevens = new List<int>();
            Console.WriteLine("Podaj ilosc elementow ciagu");
            int n = int.Parse(Console.ReadLine());
            
            for(int i=0;i<n;i++)
            { 
            Console.WriteLine("Podaj liczbe");
            int x = int.Parse(Console.ReadLine());
            numbers.Add(x);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }


                if (numbers[i] % 3 == 0)
                {
                        threes.Add(numbers[i]);
                }
                    else
                    {
                        if (numbers[i] % 5 == 0)
                        {
                            fives.Add(numbers[i]);
                        }
                        else
                        {
                            if (numbers[i] % 7 == 0)
                            {
                                sevens.Add(numbers[i]);
                            }
                            else
                            {
                            Console.WriteLine("Liczba " + numbers[i]+" nie dzieli sie przez 3,5 oraz 7");
                            }
                        }
                    }
            }
            if (evens.Count != 0)
            {
                Console.WriteLine("Liczby parzyste");
                for (int i = 0; i < evens.Count; i++)
                {
                    Console.WriteLine((evens[i]) + " ");
                }
            }
            if (threes.Count != 0)
            {
                Console.WriteLine("Liczby podzielne przez 3");
                for (int i = 0; i < threes.Count; i++)
                {
                    Console.WriteLine(threes[i] + " ");
                }
            }
            if (fives.Count != 0)
            {
                Console.WriteLine("Liczby podzielne przez 5");
                for (int i = 0; i < fives.Count; i++)
                {
                    Console.WriteLine(fives[i] + " ");
                }
            }
            if (sevens.Count != 0)
            {
                Console.WriteLine("Liczby podzielne przez 7");
                for (int i = 0; i < sevens.Count; i++)
                {
                    Console.WriteLine(sevens[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
