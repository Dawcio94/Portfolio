using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad8
{
    class Zad81
    {
        
        ConsoleKeyInfo kl;
        
        public void Number()
        {
            Console.WriteLine();
            
            do
            {
                kl=Console.ReadKey();
                Thread charThread = new Thread(Char);
                charThread.Start();
                continue;
            } while (true);
            
        }
        public void Char()
        {
            char s = kl.KeyChar;
            Console.WriteLine(" "+(int)s);
            
        }
        
    }
}
