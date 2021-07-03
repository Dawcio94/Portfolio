using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Error:Exception
    {
        
      
        public Error() : base("Liczba N nie rowna sie liczby wierszy w pliku") { }
    }
}
