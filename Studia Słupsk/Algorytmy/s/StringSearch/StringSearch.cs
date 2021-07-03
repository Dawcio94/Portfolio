using System.Collections.Generic;

namespace StringSearch
{
    public static class StringSearch
    {
        public static List<int> NaiveSearch(string text, string pattern)
        {
            List<int> list = new List<int>();
            int M = pattern.Length;
            int N = text.Length;
            for(int i = 0; i <= N - M; i++)
            {
                int j;
                for (j = 0; j < M; j++)
                {
                    if (text[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == M)
                {
                    list.Add(i);
                }
            }

            return list;
        }
        static void Cmp(string pattern, int M, int[]lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;
            while (i < M)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len!=0){
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
        public static List<int> KmpSearch(string text, string pattern)
        {
            
                
            List<int> list = new List<int>();
            int M = pattern.Length;
            int N = text.Length;
            int[] lps = new int[M];
            int j = 0;
            Cmp(pattern, M, lps);
            int i = 0;
            
            while (i < N)
            {
                if (text[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                if (j == M)
                {
                    list.Add(i - j);
                    j = lps[j - 1];
                }
                else if(i<N && pattern[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i = i + 1;
                    }
                }
            }
            return list;
        }
        
    }
}
