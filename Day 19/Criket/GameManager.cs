using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criket
{
    public class GameManager
    {
        private Team team1;
        private ComputerTeam team2;

        public GameManager(Team t1, ComputerTeam t2)
        {
            team1 = t1;
            team2 = t2;
        }

        public void StartGame()
        {
            PlayInnings(team1);
            team2.Play(); // Computer team plays
            AnnounceWinner();
        }

        private void PlayInnings(Team team)
        {
            Console.WriteLine($"{team.TeamName} is batting.");
            foreach (var player in team.Players)
            {
                int runs = new Random().Next(0, 7);
                player.ScoreRuns(runs);
                team.UpdateTeamScore(runs);
                Console.WriteLine($"{player.Name} scored {runs} runs.");
            }
            Console.WriteLine($"{team.TeamName} scored a total of {team.TotalRuns} runs.\n");
        }

        private void AnnounceWinner()
        {
            if (team1.TotalRuns > team2.TotalRuns)
            {
                Console.WriteLine($"{team1.TeamName} wins!");
            }
            else if (team1.TotalRuns < team2.TotalRuns)
            {
                Console.WriteLine($"{team2.TeamName} (Computer) wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
