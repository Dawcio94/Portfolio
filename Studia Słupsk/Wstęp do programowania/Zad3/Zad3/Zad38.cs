using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad3
{
    class Zad38
    {
        public void Overflow()
        {
            byte a = 0; //deklaracja zmiennej a o type byte(zakres liczbowy od 0 do 255)
            while (true) //pętla która bedzie ciagle wykonywana
            {
                Console.WriteLine(a); //wypisanie wartosci a w konsoli
                a++;               //zwiekszanie wartosci zmienne a o 1
                Thread.Sleep(100); //wątek powodujacy tzw uspienie programu, aby uzytkownik mogl zauwazyc wynik
            }
            //po dojsciu do wartosci granicznej danego typu zadeklarowanej zmiennej z prawej strony,następuje przepelnienie i powrót do minimalnej 
            //wartosci zadeklarowanego typu
        }
    }
}
