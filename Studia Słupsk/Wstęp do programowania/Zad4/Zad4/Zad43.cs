using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad43
    {
        public void Multiply()
        {
            int [,] matrix=new int[11,11];
            for(int i = 0; i <= 10; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                    matrix[i, j] = i * j;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write(matrix[j, i]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
