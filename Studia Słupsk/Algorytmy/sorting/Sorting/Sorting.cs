using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Sorting
    {
        static void Swap(int[]data,int a, int b) {
            int t = data[a];
            data[a] = data[b];
            data[b] = t;
        }
        public static int[] SelectionSort(int[] data)
        {

            int k;
            for (int i = 0; i < data.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < data.Length; j++)
                {

                    if (data[j] < data[k])
                    {
                        k = j;
                    }

                }
                Swap(data, k, i);
            }
            return data;
        }

        public static int[] InsertionSort(int[] data)
        {
            return null;
        }

        public static int[] MergeSort(int[] data)
        {
            return null;
        }

        public static int[] quicksortimpl(int[] data, int left, int right)
        {
            int i = left;
            int j = right;
            int x = data[(left + right) / 2];
            do
            {
                while (data[i] < x)
                {
                    i++;
                }
                while (data[j] > x)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(data, i, j);
                    i++;
                    j--;
                }

            } while (i <= j);
            if (left < j)
            {
               quicksortimpl(data, left, j);
               
            }
            if (right > i)
            {
                quicksortimpl(data, i, right);

            }
            return data;
        }

        public static int[] QuickSort(int[] data)
        {
            int a = 0;
            int b = data.Length -1 ;
            quicksortimpl(data, a, b);
            return data; 
        }

        public static int[] HeapSort(int[] data)
        {
            return null;
        }
    }
}
