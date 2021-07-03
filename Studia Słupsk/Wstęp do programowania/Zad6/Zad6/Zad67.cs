using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad6
{
    class Zad67
    {
        public void Triangle()
        {
            Console.WriteLine("Podaj długosc boku a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długosc boku b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długosc boku c");
            float c = float.Parse(Console.ReadLine());
            string s1 = "",s2="",s3="";

            if(a+b>c && a+c>b && b + c > a)
            {
                s1 = "Istnieje taki trojkat";
                if (a == b && a == c)
                {
                    s2 = "rownoboczny";
                }
                else
                {
                    if(a==b || a==c || b == c)
                    {
                        s2 = "rownoramienny";
                    }
                    else
                    {
                        s2 = "zwykły";
                    }
                }
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)|| Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)|| 
                    Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                {
                    s3 = "prostokatny";
                }
                else
                {
                    if(Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) > Math.Pow(b, 2) ||
                    Math.Pow(c, 2) + Math.Pow(b, 2) > Math.Pow(a, 2)){
                        s3 = "ostrokatny";
                    }
                    else
                    {
                        s3 = "ostrokątny";
                    }
                }
                Console.WriteLine(s1 + " i jest to trojkat " + s2+" i "+s3);
            }
            else
            {
                Console.WriteLine("Nie ma takiego trojkata");
            }
            
        }
    }
}
