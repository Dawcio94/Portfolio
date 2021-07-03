using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{
    class Zad88
    {
        DirectoryInfo di = new DirectoryInfo(@"D:\Dawid\Studia Słupsk\I rok\I semestr\Programowanie\Zad8\Zad8\bin\Debug");
        public void Files(string s)
        {
            Program(s);

        }

        public void Program(string s)
        {
            string m = di.ToString() + "$";
            do
            {
                if (s == "ls")
                {
                    foreach (var fi in di.GetFiles())
                    {
                        Console.WriteLine(fi.Name);
                    }
                    Console.Write(m);
                    s = Console.ReadLine();
                    continue;
                }
                else if (s.Contains("cd "))
                {
                    try
                    {
                        string k = s.Replace("cd ", "");
                        bool path = Path.IsPathRooted(k);
                        if (k == ".")
                        {
                            di = new DirectoryInfo(Directory.GetParent(di.ToString()).ToString());
                            m = di.ToString() + "$";
                            Console.Write(m);
                            s = Console.ReadLine();
                            continue;
                        }
                        if (path == true) {
                            di = new DirectoryInfo(k);
                            m = di.ToString() + "$";
                            Console.Write(m);
                            s = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawna ścieżka");
                            Console.Write(m);
                            s = Console.ReadLine();
                            continue;
                        }
                       
                    }
                    catch (Exception e)
                    {
                        
                    }
                }
                else if (s == "exit")
                {
                    Environment.Exit(0);
                    break;
                }
                else if (s == "quit")
                {
                    Environment.Exit(0);
                    break;
                }
                else if (s == "q")
                {
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Podaj inna komende");
                    Console.Write(m);
                    s = Console.ReadLine();
                    continue;
                }
            } while (s != "exit" || s != "q" || s != "quit");
        }
    }
}
