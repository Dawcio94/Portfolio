using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
   class Zad412
    {
        enum Color { Red, Blue, Green };
        public void Colors()
        {
            Console.WriteLine("Podaj kolor");
            string s = Console.ReadLine();  
           if (Enum.IsDefined(typeof(Color),s))
            {
                Console.WriteLine("Kolor jest zawarty w palecie");
            }
            else
            {
                Console.WriteLine("Nie ma takiego koloru");
            }  
        }
    }
}
