using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Zad8
{
    class Zad87
    {
        public void Text(string s, params string[] answers)
        {
            int n = 0, ci = 0,si=0 ;
            string line;
            List<char> list = new List<char>();
            using (StreamReader sr=new StreamReader("plik.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(s))
                    {
                        break;
                    }
                    ++n;
                }
            }
            while (ci < line.Length)
            {
                var all = line[ci];
                var ch = s[si];
                if (ch == all)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(ch);
                    si++;
                    
                }
                else
                {
                    Console.Write(all);
                    Console.ResetColor();
                    
                }
                ci++;
            }
        }
    }
}
