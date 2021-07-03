using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Zad75
    {
        
            public double Determ(double[,] a ,int n)
            {
                            
                double det = 0;
                double[,] temp = new double[n,n];
                int p, h, k, i, j;
                if (n == 1)
                {
                    return a[0,0];
                }
                else if (n == 2)
                {
                    det = (a[0,0] * a[1,1] - a[0,1] * a[1,0]);
                    return det;
                }
                else
                {
                    for (p = 0; p < n; p++)
                    {
                        h = 0;
                        k = 0;
                        for (i = 1; i < n; i++)
                        {
                            for (j = 0; j < n; j++)
                            {
                                if (j == p)
                                {
                                    continue;
                                }
                                temp[h,k] = a[i,j];
                                k++;
                                if (k == n - 1)
                                {
                                    h++;
                                    k = 0;
                                }
                            }
                        }
                        det = det + a[0,p] * Math.Pow(-1, p) * Determ(temp, n - 1);
                    }
                    return det;
                }
            }
        }
}
