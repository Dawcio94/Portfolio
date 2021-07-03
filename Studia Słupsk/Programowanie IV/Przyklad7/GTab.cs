using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad7
{
    class GTab<T>
    {

        T[] ar;

        public GTab(int n)
        {
            ar = new T[n];
        }

        public void Ustaw(int index, T element)
        {
            ar[index] = element;
        }

        public T Wypisz(int index)
        {
            return ar[index];
        }

        public void change(GTab <T> array,int n)
        {
            for (int i = 0; i < (n / 2); i++)
            {
                T a = array.Wypisz(i);
                T b = array.Wypisz((n - 1) - i);
                array.Ustaw(i, b);
                array.Ustaw((n - 1) - i, a);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array.Wypisz(i) + "\t");
            }
        }
    }
}
