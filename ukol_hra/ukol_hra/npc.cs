using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Npc
    {
        public string name;
        public string difficulty;
        public string topic;
        public int points;
        public Npc(string name, string difficulty, string topic, int points)
        { 
            this.name = name;
            this.difficulty = difficulty;
            this.topic = topic;
            this.points = points;
        }
    }
}
