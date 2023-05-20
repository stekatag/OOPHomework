using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class Game
    {
        private readonly List<Goal> goals = new List<Goal>();

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; } = new List<Referee>();
        public IReadOnlyList<Goal> Goals => goals.AsReadOnly();
        public string Result { get; set; }
        public Team Winner { get; private set; }

        // The reason for having both a private List<Goal>
        // and a public IReadOnlyList<Goal> property is to control the access to the list of goals.

        // The private List<Goal> field provides a mutable list that can be modified within the Game class.
        // The public IReadOnlyList<Goal> property provides a read-only view of the goals list.
        // By exposing it as a read-only list, external code can access the goals but cannot modify them.

        public Game(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees = new List<Referee>();
            goals = new List<Goal>();
        }

        public void AddGoal(int minute, FootballPlayer player, Team team)
        {
            Goal goal = new Goal(minute, player, team);
            goals.Add(goal);
        }

        public void SetResult()
        {
            int team1Goals = goals.Count(goal => goal.Team == Team1);
            int team2Goals = goals.Count(goal => goal.Team == Team2);

            Result = $"{team1Goals}:{team2Goals}";

            if (team1Goals > team2Goals)
            {
                Winner = Team1;
            }
            else if (team2Goals > team1Goals)
            {
                Winner = Team2;
            }
        }
    }
}
