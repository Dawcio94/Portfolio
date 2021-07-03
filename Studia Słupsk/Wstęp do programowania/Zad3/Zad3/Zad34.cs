using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad34
    {
        public void Counting()
        {
            int st = 0;
            double[,] matrix = new double[2, 91];
            for (st = 0; st <=90; st+=15)
            {
                matrix[0, st] = st;
                matrix[1, st] = Math.Sin((Math.PI*st)/180);
            }

            for(int i = 0; i <=90; i+=15)
            {
                for(int j = 0; j < 2;j++)
                {
                    Console.Write(matrix[j, i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
