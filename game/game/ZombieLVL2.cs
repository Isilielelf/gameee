using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class ZombieLVL2
    {
         string nameZom2;
        int hpZom2;
        int dmZom2;
        int ptZom2;
        int expZom2;
        int coinZom2;

        public ZombieLVL2(string nameZ2, int hpZ2, int dmZ2, int ptZ2, int lvlZ2, int coZ2)
        {
            nameZom2 = nameZ2;
            hpZom2 = hpZ2;
            dmZom2 = dmZ2;
            ptZom2 = ptZ2;
            expZom2 = lvlZ2;
            coinZom2 = coZ2;
        }

        public string name
        {
            get => nameZom2;
            set => nameZom2 = value;
        }
        public int hp
        {
            get => hpZom2;
            set => hpZom2 = value;
        }

        public int dm
        {
            get => dmZom2;
            set => dmZom2 = value;
        }
        public int pt
        {
            get => ptZom2;
            set => ptZom2 = value;
        }
        
        public int exp
        {
            get => expZom2;
            set => expZom2 = value;
        }
        public int coin
        {
            get => coinZom2;
            set => coinZom2 = value;
        }
    }
}
