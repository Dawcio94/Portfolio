using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoare
{
    public static class HoareAlgorithm
    {
        public static int QuickSelect(int[] data, int n)
        {
            if (data.Length == 1 && n == 1)
            {
                return data[0];
            }
            int m ;
            int l = 0;
            int r = data.Length;
            int t = 0;
            int i, j;
            while (l < r)
            {
                m = data[n];
                i = l;
                j = r;
                while (true)
                {
                    while (data[i] < m)
                    {
                        i++;
                    }
                    while (data[j] > m)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        t = data[i];
                        data[i] = data[j];
                        data[j] = t;
                        i++;
                        j--;
                    }
                    
                }
                
                return data[n];
            }
            return -1;
        }
    }
}
