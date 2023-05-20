using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }
        public Team Team { get; set; }

        public Goal(int minute, FootballPlayer player, Team team)
        {
            Minute = minute;
            Player = player;
            Team = team;
        }
    }
}
