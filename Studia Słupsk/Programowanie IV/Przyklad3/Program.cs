using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad3
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<Book> books = new Stack<Book>();
            Console.WriteLine("Podaj liczbe ksiazek");
            int n = int.Parse(Console.ReadLine());

            void Sort(Stack<Book> stack)
            {
                Stack<Book> temp = new Stack<Book>();
                while (stack.Count > 0)
                {
                    Book b = stack.Pop();
                    while (temp.Count > 0 && b.pages > temp.Peek().pages)
                    {
                        stack.Push(temp.Pop());
                    }
                    temp.Push(b);
                }
                while (temp.Count > 0)
                {
                    stack.Push(temp.Pop());
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj tytul");
                string tit = Console.ReadLine();
                Console.WriteLine("Podaj autora");
                string aut = Console.ReadLine();
                Console.WriteLine("Podaj ilosc stron");
                int pag = Convert.ToInt32(Console.ReadLine());

                books.Push(new Book(tit, aut, pag));
            }

            Sort(books);

            while(books.Count>0)
            {
                Console.WriteLine(books.Pop());
            }
            Console.ReadKey();
        }
    }
}
