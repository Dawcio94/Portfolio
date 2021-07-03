using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad411
    {
        public void Keyq()
        {
            Console.WriteLine("Przycisk Q jest magiczny");
            ConsoleKeyInfo kl;
            kl = Console.ReadKey();
            while (kl.Key != ConsoleKey.Q)
            {
                
            }
        }
    }
}
