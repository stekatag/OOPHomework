// Creating instances of players
using OOPHomework;

// Creating instances of players for team1
FootballPlayer[] manUtd =
{
    new Striker("Marcus Rashford", 20, 1, 1.80),
    new Striker("Anthony Martial", 21, 2, 1.81),
    new Midfield("Bruno Fernandes", 22, 3, 1.82),
    new Midfield("Fred", 23, 4, 1.83),
    new Midfield("Casemiro", 24, 5, 1.84),
    new Midfield("Christian Eriksen", 25, 6, 1.85),
    new Defender("Digo Dalot", 26, 7, 1.86),
    new Defender("Lisandro Martinez", 27, 8, 1.87),
    new Defender("Raphael Varane", 28, 9, 1.88),
    new Defender("Luke Shaw", 29, 10, 1.89),
    new Goalkeeper("David de Gea", 30, 11, 1.90)
};

// Creating instances of players for team2
FootballPlayer[] manCity =
{
    new Striker("Erling Haaland", 20, 1, 1.80),
    new Striker("Julian Alvarez", 21, 2, 1.81),
    new Midfield("Phil Foden", 24, 3, 1.82),
    new Midfield("Kevin De Bruyne", 23, 4, 1.83),
    new Midfield("Jack Grealish", 24, 5, 1.84),
    new Midfield("Ilkay Gundogan", 25, 6, 1.85),
    new Defender("Kyle Walker", 26, 7, 1.86),
    new Defender("Ruben Dias", 27, 8, 1.87),
    new Defender("Nathan Ake", 28, 9, 1.88),
    new Defender("Manuel Akanji", 29, 10, 1.89),
    new Goalkeeper("Ederson", 30, 11, 1.90),
};

// Creating instances of coaches and teams
Coach coach1 = new Coach("Erik ten Hag", 45);
Coach coach2 = new Coach("Pep Guardiola", 50);

Team team1 = new Team(coach1, manUtd);
Team team2 = new Team(coach2, manCity);

// Creating instances of referee and assistant referees
Referee referee = new Referee("Anthony Taylor", 45);
Referee assistantReferee1 = new Referee("Craig Pawson", 30);
Referee assistantReferee2 = new Referee("Paul Tierney", 28);

// Creating an instance of the game/match
Game match = new Game(team1, team2, referee);
match.AssistantReferees.Add(assistantReferee1);
match.AssistantReferees.Add(assistantReferee2);

// Adding goals to the match
match.AddGoal(10, manUtd[0], team1);
match.AddGoal(20, manUtd[1], team1);
match.AddGoal(30, manCity[0], team2);
match.AddGoal(40, manCity[1], team2);
match.AddGoal(50, manUtd[2], team1);

// Setting the result of the match
match.SetResult();

// Printing the result of the match
void printWinner()
{
    if(match.Winner == null)
    {
        Console.WriteLine("Match is a draw");
        return;
    };
    Console.WriteLine($"Winner: {match.Winner.Coach.Name}");
}

// Printing the goals of the match
void printGoals()
{
    Console.WriteLine("Goals:");
    foreach (Goal goal in match.Goals)
    {
        Console.WriteLine($"Minute: {goal.Minute}, Player: {goal.Player.Name}");
    }
}

// Printing the referees of the match
void printReferees()
{
    Console.WriteLine("Referees:");
    Console.WriteLine($"Head Referee: {referee.Name}");
    foreach (Referee assistantReferee in match.AssistantReferees)
    {
        Console.WriteLine($"Assistant Referee: {assistantReferee.Name}");
    }
}

void printBreakline()
{
    Console.WriteLine("-----------------------------------");
}

Console.WriteLine($"Match Result:  {match.Result}");
printWinner();
printBreakline();
printGoals();
printBreakline();

// Average age of the players in the match
Console.WriteLine($"Average age of team 1: {team1.AveragePlayerAge}");
Console.WriteLine($"Average age of team 2: {team2.AveragePlayerAge}");
printBreakline();
printReferees();
