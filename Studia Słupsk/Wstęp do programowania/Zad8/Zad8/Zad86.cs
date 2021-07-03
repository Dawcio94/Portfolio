using System.IO;

namespace Zad8
{
    class Zad86
    {
        public int Count(string s)
        {
            using (StreamReader sr = new StreamReader(s))
            {
                int n = 0;
                while (sr.ReadLine() != null)
                {
                    n++;
                }
                return n;
            }
        }
    }
}