using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Zad42
    {
        public void PKB()
        {
            int pol=614121,usa=80000000,niem=3700000,szw=538575,arab=1379550;
            string pols,usas,niems,szws,arabs;
            pols = pol.ToString("c", CultureInfo.CreateSpecificCulture("pl-PL"));
            niems = niem.ToString("c", CultureInfo.CreateSpecificCulture("de-DE"));
            usas = usa.ToString("c", CultureInfo.CreateSpecificCulture("en-US"));
            szws = szw.ToString("c", CultureInfo.CreateSpecificCulture("sv"));
            arabs = arab.ToString("c", CultureInfo.CreateSpecificCulture("ar-SA"));
            Console.WriteLine($"{pols}");
            Console.WriteLine($"{niems}");
            Console.WriteLine($"{usas}");
            Console.WriteLine($"{szws}");
            Console.WriteLine($"{arabs}");

        }
    }
}
