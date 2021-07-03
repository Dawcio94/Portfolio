using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{

    class Zad77
    {
        public struct Book
        {
            public string Tittle;
            public string Author;
            public int Year;
            public string Published;
            public bool Borrowed;
            public Book(string tittle, string author, int year, string published, bool borrowed)
            {
                Tittle = tittle;
                Author = author;
                Year = year;
                Published = published;
                Borrowed = borrowed;
            }
        }
        public Book ksiazka = new Book("Kubus", "Adam Nowak", 2012, "PWN", false);
        public void Add(List<Book> list)
        {
            string tittles;
            string authors;
            int years;
            string publisheds;
            bool borroweds;
            Console.WriteLine("Dodanie nowej ksiazki");
            Console.WriteLine("Podaj tytul");
            tittles = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            authors = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania");
            years = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wydawnictwo");
            publisheds = Console.ReadLine();
            Console.WriteLine("Podaj czy jest dostepna");
            borroweds = bool.Parse(Console.ReadLine());
            Book book = new Book(tittles, authors, years, publisheds, borroweds);
            list.Add(book);
            Console.WriteLine("Wybierz inna opcje");
        }
        public void Show(List<Book> list)
        {
            Console.WriteLine();
            foreach (Book a in list)
            {
                Console.WriteLine("Tytul: " + a.Tittle + " Autor: " + a.Author + " Rok wydania: " + a.Year + " Wydawnictwo: " + a.Published + " Dostępna: " + a.Borrowed);
                Console.WriteLine("Wybierz inna opcje");
            }
        }
        public void Delete(List<Book> list)
        {

            string s;
            Console.WriteLine("Wybierz kryterium do usuniecia ksiazki");
            Console.WriteLine("A-Autor");
            Console.WriteLine("T-Tytuł");
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                Console.WriteLine("Podaj autora wedlug ktorego beda usuwane ksiazki");
                s = Console.ReadLine();
                foreach (Book a in list)
                {
                    list.RemoveAll(r => r.Author.Contains(s));
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }
            if (info.Key == ConsoleKey.T)
            {
                Console.WriteLine("Podaj tytul wedlug ktorego beda usuwane ksiazki");
                s = Console.ReadLine();
                foreach (Book a in list)
                {
                    list.RemoveAll(r => r.Tittle.Contains(s));
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }
        }
        public void Search(List<Book> list)
        {
            int n;
            string s;
            Console.WriteLine("Wybierz kryterium do wyszukania ksiazki");
            Console.WriteLine("A-Autor");
            Console.WriteLine("T-Tytuł");
            Console.WriteLine("R-Rok wydania");
            Console.WriteLine("W-Wydawnictowo");
            Console.WriteLine("D-Dostępna");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.A)
            {
                Console.WriteLine("Podaj autora");
                s = Console.ReadLine();
                foreach (Book a in list)
                {
                    if (a.Author.Contains(s))
                    {
Console.WriteLine("Tytul: " + a.Tittle + " Autor: " + a.Author + " Rok wydania: " + a.Year + " Wydawnictwo: " + a.Published + " Dostępna: " + a.Borrowed);
                    }
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }
            else if (info.Key == ConsoleKey.T)
            {
                Console.WriteLine("Podaj tytul");
                s = Console.ReadLine();
                foreach (Book a in list)
                {
                    if (a.Tittle.Contains(s))
                    {
Console.WriteLine("Tytul: " + a.Tittle + " Autor: " + a.Author + " Rok wydania: " + a.Year + " Wydawnictwo: " + a.Published + " Dostępna: " + a.Borrowed);
                    }
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }
            else if (info.Key == ConsoleKey.R)
            {
                Console.WriteLine("Podaj rok");
                n = int.Parse(Console.ReadLine());
                foreach (Book a in list)
                {
                    if (a.Year==n)
                    {
Console.WriteLine("Tytul: " + a.Tittle + " Autor: " + a.Author + " Rok wydania: " + a.Year + " Wydawnictwo: " + a.Published + " Dostępna: " + a.Borrowed);
                    }
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }
            else if (info.Key == ConsoleKey.W)
            {
                Console.WriteLine("Podaj wydawnictwo");
                s = Console.ReadLine();
                foreach (Book a in list)
                {
                    if (a.Published.Contains(s)) {
Console.WriteLine("Tytul: " + a.Tittle + " Autor: " + a.Author + " Rok wydania: " + a.Year + " Wydawnictwo: " + a.Published + " Dostępna: " + a.Borrowed);
                    }
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }
            else if (info.Key == ConsoleKey.D)
            {
                Console.WriteLine("Podaj true lub false");
                s = Console.ReadLine();
                foreach (Book a in list)
                {
                    if (a.Borrowed.ToString().Contains(s))
                    {
Console.WriteLine("Tytul: " + a.Tittle + " Autor: " + a.Author + " Rok wydania: " + a.Year + " Wydawnictwo: " + a.Published + " Dostępna: " + a.Borrowed);
                    }
                    break;
                }
                Console.WriteLine("Wybierz inna opcje");
            }

        }

        public void Library(ConsoleKeyInfo kl)
        {
            List<Book> list = new List<Book>
            {
                ksiazka
            };
            do
            {
                switch (kl.Key)
                {
                    case ConsoleKey.D1:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Nie ma żadnej książki:(");
                            Console.WriteLine("Wybierz inna opcje");
                            kl = Console.ReadKey();
                            Console.WriteLine();
                        }
                        else
                        {
                            Show(list);
                            kl = Console.ReadKey();
                            Console.WriteLine();
                        }
                        continue;

                    case ConsoleKey.D2:
                        Add(list);
                        kl = Console.ReadKey();
                        Console.WriteLine();
                        continue;
                    case ConsoleKey.D3:
                        Delete(list);
                        kl = Console.ReadKey();
                        Console.WriteLine();
                        continue;
                    case ConsoleKey.D4:
                        Search(list);
                        kl = Console.ReadKey();
                        Console.WriteLine();
                        continue;
                    default:
                        break;
                }
            } while (kl.Key != ConsoleKey.Escape);
        }
    }
}
