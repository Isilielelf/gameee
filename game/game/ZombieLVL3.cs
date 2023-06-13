using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class ZombieLVL3
    {
        string nameZom3;
        int hpZom3;
        int dmZom3;
        int ptZom3;
        int expZom3;
        int coinZom3;

        public ZombieLVL3(string nameZ3, int hpZ3, int dmZ3, int ptZ3, int lvlZ3, int coZ3)
        {
            nameZom3 = nameZ3;
            hpZom3 = hpZ3;
            dmZom3 = dmZ3;
            ptZom3 = ptZ3;
            expZom3 = lvlZ3;
            coinZom3 = coZ3;
        }

        public string name
        {
            get => nameZom3;
            set => nameZom3 = value;
        }
        public int hp
        {
            get => hpZom3;
            set => hpZom3 = value;
        }

        public int dm
        {
            get => dmZom3;
            set => dmZom3 = value;
        }
        public int pt
        {
            get => ptZom3;
            set => ptZom3 = value;
        }

        public int exp
        {
            get => expZom3;
            set => expZom3 = value;
        }
        public int coin
        {
            get => coinZom3; 
            set => coinZom3 = value;
        }
    }
}
