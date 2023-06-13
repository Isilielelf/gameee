using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
   public class Monsters
    {
        string nameMon;
        int hpMon;
        int dmMon;
        int ptMon;
        int expMon;
        int coinMon;

        public Monsters(string nameM, int hpM, int dmM, int ptM, int expM, int coM)
        {
            nameMon = nameM;
            hpMon = hpM;
            dmMon = dmM;
            ptMon = ptM;
            expMon = expM;
            coinMon = coM;
        }

        public string name
        {
            get => nameMon;
            set => nameMon = value;
        }
        public int hp
        {
            get => hpMon;
            set => hpMon = value;
        }

        public int dm
        {
            get => dmMon;
            set => dmMon = value;
        }
        public int pt
        {
            get => ptMon;
            set => ptMon = value;
        }
        
        public int exp
        {
            get => expMon;
            set => expMon = value;
        }
        public int coin
        {
            get => coinMon;
            set => coinMon = value;
        }
    }
}
