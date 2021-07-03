using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_PKS
{
    class Partial
    {
    }
    public partial class Miejscowości
    {

        public override string ToString()
        {
            return this.Nazwa_miejscowosci;
        }
    }
    public partial class Trasa
    {
        public override string ToString()
        {
            return this.Oznaczenie_trasy;
        }
    }
    public partial class Kurs
    {
        public override string ToString()
        {
            return this.Oznaczenie;
        }
    }
}
