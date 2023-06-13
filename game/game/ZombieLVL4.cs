using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class ZombieLVL4
    {
        string nameZom4;
        int hpZom4;
        int dmZom4;
        int ptZom4;
        int expZom4;
        int coinZom4;

        public ZombieLVL4(string nameZ4, int hpZ4, int dmZ4, int ptZ4, int lvlZ4, int coZ4)
        {
            nameZom4 = nameZ4;
            hpZom4 = hpZ4;
            dmZom4 = dmZ4;
            ptZom4 = ptZ4;
            expZom4 = lvlZ4;
            coinZom4 = coZ4;
        }

        public string name
        {
            get => nameZom4;
            set => nameZom4 = value;
        }
        public int hp
        {
            get => hpZom4;
            set => hpZom4 = value;
        }

        public int dm
        {
            get => dmZom4;
            set => dmZom4 = value;
        }
        public int pt
        {
            get => ptZom4;
            set => ptZom4 = value;
        }

        public int exp
        {
            get => expZom4;
            set => expZom4 = value;
        }

        public int coin
        {
            get => coinZom4; 
            set => coinZom4 = value;
        }
    }
}
