using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            Stack<int> result = new Stack<int>();


            Console.WriteLine("Podaj liczbe par liczb");
            int n = int.Parse(Console.ReadLine());

            bool check(int a)
            {
                if (a < 2)
                {
                    return false;
                }
                for (int i = 2; i <= Math.Sqrt(a); i++)
                    if (a % i == 0) return false;

                return true;
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj pierwsza liczbe z " + (i + 1) + "pary");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj druga liczbe z " + (i + 1) + "pary");
                int y = int.Parse(Console.ReadLine());
                stack.Push(x);
                stack.Push(y);
            }

            while(stack.Count>0)
            {
                int x =stack.Pop();
                int y =stack.Pop();

                if (check(x) == true)
                {
                    result.Push(x + y);
                }
                else
                {
                    if (check(y) == true)
                    {
                        result.Push(x + y);
                    }
                    else
                    {

                    }
                }   
            }


            Console.WriteLine("Stos wynikowy");
            while (result.Count > 0)
            {
                Console.WriteLine(result.Peek());
                result.Pop();
            }

            Console.ReadKey();
        }
    }
}
