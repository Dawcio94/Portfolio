using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> liczby = new Stack<int>();
            Stack<int> result = new Stack<int>();
            Random x = new Random();

            Console.WriteLine("Ile elementow na stosie");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Losowane");

            for (int i = 0; i < n; i++)
            {
                int y = x.Next(1, 30);
                liczby.Push(y);
                Console.WriteLine(y);
            }
            int[] array = new int[n];
            array = liczby.ToArray();

            var query = array.GroupBy(a => a).Select(z => (key: z.Key, val: z.Count()));

            foreach(var item in query)
            {
                result.Push(item.val);
                result.Push(item.key);
            }

            Console.WriteLine("Wystapienia");
            while (result.Count > 0)
            {
                Console.Write(result.Pop()+"\t"+result.Pop() );
                Console.WriteLine();
            }

            Console.ReadKey();



        }
    }
}
