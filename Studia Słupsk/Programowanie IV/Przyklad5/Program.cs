using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            List<Book> result = new List<Book>();
            List<Book> sorted = new List<Book>();
            Console.WriteLine("Podaj liczbe ksiazek");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj tytul");
                string tit = Console.ReadLine();
                Console.WriteLine("Podaj autora");
                string aut = Console.ReadLine();
                Console.WriteLine("Podaj ilosc stron");
                int pag = Convert.ToInt32(Console.ReadLine());

                books.Add(new Book(tit, aut, pag));
            }

            Console.WriteLine("Podane imie i nazwisko autora");
            string name = Console.ReadLine();
            
            foreach(var item in books)
            {
                if (name==item.author)
                {
                    result.Add(item);
                }
            }
            sorted = result.OrderBy(x => x.pages).ToList();


            Console.WriteLine("Wybrane i posortowane ksiazki");
            for(int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i]);
            }

            Console.ReadKey();
        }
    }
}
