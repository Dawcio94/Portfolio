using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] dirs = Directory.GetFiles(Directory.GetCurrentDirectory().ToString(), "*.txt");
            char ch;
            int i = 0;
            //Directory.CreateDirectory("PlikiStworzone");
            foreach (var p in dirs)
            {
                FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read);
                string text = File.ReadAllText(p);
                do
                {
                    fs.Position = i;
                    ch = (char)fs.ReadByte();
                    if ((int)ch > 0 && (int)ch < 9)
                    {
                        
                        var filename = Path.GetFileName(p);
                        File.Move(filename, ("PlikiStworzone\\" + filename));
                    }
                    else
                    {
                        i++;
                    }
                } while ((int)ch < 9);
                fs.Close();
            }
        }
    }
}
