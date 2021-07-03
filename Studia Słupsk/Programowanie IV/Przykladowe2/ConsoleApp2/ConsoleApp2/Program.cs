using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String k;
            k = File.ReadAllText("teksty.txt");
            Console.WriteLine(k);
            Console.WriteLine("*****************************");
            FileStream fs = new FileStream("teksty.txt", FileMode.Open, FileAccess.Read);
            fs.Seek(1, SeekOrigin.Begin);
            k = File.ReadAllText("teksty.txt");
            File.AppendAllText("liczby.txt", k);
            int v = fs.ReadByte();
            Console.WriteLine(v);
            Console.WriteLine("*****************************");
            fs.Seek(1, SeekOrigin.Current);
            v = fs.ReadByte();
            Console.WriteLine(v);
            Console.WriteLine("*****************************");
            fs.Position = 10;
            v = fs.ReadByte();
            Console.WriteLine((char)v);
            Console.WriteLine("*****************************");
            Directory.CreateDirectory("NOWY1");
            String[] dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
            foreach (string j in dirs)
            { Console.WriteLine(j); }
            Console.WriteLine("*****************************");
            FileInfo g = new FileInfo("liczby.txt");
            Console.WriteLine(g.Length);

            Console.ReadKey();

        }
    }
}
