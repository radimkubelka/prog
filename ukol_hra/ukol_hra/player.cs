using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Player
    {
        public string name;
        public int kp;          //knowledge point
        public Player(int kp)
        {
            this.kp = kp;
        }
    }
}
