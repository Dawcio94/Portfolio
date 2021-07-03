using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class Search
    {
        public static int SearchLinear(List<int> data, int value)
        {
            for (int i = 0; i < data.Count; ++i)
            {
                if (data[i] == value)
                {
                    return i;
                }   
            }
            return -1;
        }

        public static int SearchBinary(List<int> data, int value)
        {
            int l = 0,p = data.Count-1, sr=0;
            
            
                while (l <= p)
                {
                    sr = (l + p) / 2;
                    if (data[sr] == value)
                    {
                        return sr;
                    }
                    
                        if (data[sr] > value)
                        {
                            p = sr - 1;
                        }
                        else
                        {
                            l = sr + 1;
                        }
                }
                return -1;
        }
    }
}
