using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        public int score { get; set; }

        public Player(int iD, String imie)
        {
            id = iD;
            name = imie;
            score = 0;
        }
       
    }
}
