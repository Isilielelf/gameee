using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Player
    {


        string namePlay;
        int hpPlay;
        int dmPlay;
        int ptPlay;
        int expPlay;
        int coinPlay;



        public Player(string nameP, int hpP, int dmP, int ptP, int expP, int coP)
        {
            namePlay = nameP;
            hpPlay = hpP;
            dmPlay = dmP;
            ptPlay = ptP;
            expPlay = expP;
            coinPlay = coP;
           
        }
        public string name
        {
            get => namePlay;
            set => namePlay = value;
        }

        public int hp
        {
            get => hpPlay;
            set => hpPlay = value;
        }

        public int dm
        {
            get => dmPlay;
            set => dmPlay = value;
        }
        public int pt
        {
            get => ptPlay;
            set => ptPlay = value;
        }
        public int exp
        {
            get => expPlay;
            set => expPlay = value;
        }
        public int coin
        {
            get => coinPlay;
            set => coinPlay = value;
        }
    }
   
}
