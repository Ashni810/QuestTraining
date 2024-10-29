using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criket
{
    using System;

    public class ComputerTeam : Team
    {
        private Random random;

        public ComputerTeam(string teamName) : base(teamName)
        {
            random = new Random();
        }

        public void Play()
        {
            Console.WriteLine($"{TeamName} (Computer) is batting.");
            foreach (var player in Players)
            {
                int runs = random.Next(0, 7); // 0 to 6 runs per ball
                player.ScoreRuns(runs);
                UpdateTeamScore(runs);
                Console.WriteLine($"{player.Name} scored {runs} runs.");
            }
            Console.WriteLine($"{TeamName} scored a total of {TotalRuns} runs.\n");
        }
    }
}

