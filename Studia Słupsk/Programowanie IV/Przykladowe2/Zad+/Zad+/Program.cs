using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zad_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("plik1.txt"),all="";
            char ch;
            Console.WriteLine(text);
            File.Copy("plik1.txt", "plikskopiowany.txt");
            FileStream fs = new FileStream("plik1.txt", FileMode.Open, FileAccess.Read);
            for(int i=0;i<text.Length;i+=10)
            {
                fs.Position = i;
                ch = (char)fs.ReadByte();
                all += ch + " ";
                
            }
            fs.Close();
            File.AppendAllText("znaki.txt", all);
            Directory.CreateDirectory("PlikiStworzone");
            File.Move("plikskopiowany.txt", "PlikiStworzone\\plikskopiowany.txt");
            File.Move("znaki.txt", "PlikiStworzone\\znaki.txt");
        }
    }
}
