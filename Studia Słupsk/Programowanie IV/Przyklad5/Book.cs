using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad5
{
    class Book
    {
        public string tittle, author;
        public int pages;
        public Book(string t, string a, int p)
        {
            tittle = t;
            author = a;
            pages = p;
        }
        public override string ToString()
        {
            return "Tytul:" + tittle + ",Autor:" + author + ",Ilosc stron:" + pages;
        }
    }
}
