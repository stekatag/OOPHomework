using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class Team
    {
        private const int RequiredPlayers = 11;
        private readonly FootballPlayer[] players;

        public Coach Coach { get; set; }
        public double AveragePlayerAge
        {
            get
            {
                int totalAge = 0;
                foreach (FootballPlayer player in players)
                {
                    totalAge += player.Age;
                }
                return Math.Round(totalAge / (double)players.Length, 2);
            }
        }

        public Team(Coach coach, FootballPlayer[] players)
        {
            Coach = coach;

            if (players.Length != RequiredPlayers)
            {
                throw new InvalidOperationException($"The team must start with {RequiredPlayers} players.");
            }

            this.players = players;
        }
    }
}
