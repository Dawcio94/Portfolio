using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad47
    {
        public void Mirror()
        {
            Console.WriteLine("Podaj słowo");
            string s = Console.ReadLine();
            char[] mir = new char[s.Length];
            mir = s.ToCharArray();
            int a = mir.Length;
            //Console.Write(mir);
            for(int i = s.Length-1; i >= 0; i--)
            {
                Console.Write(mir[i]);
            }
        }
    }
}
