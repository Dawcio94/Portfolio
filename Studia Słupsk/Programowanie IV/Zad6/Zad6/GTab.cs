using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class GTab<T>
    {

        T[] ar;

        public GTab(int n)
        {
            ar = new T[n];
        }

        public void Ustaw(int index,T element)
        {
            ar[index] = element;
        }

        public T Wypisz(int index)
        {
            return ar[index];
        }
    }
}
