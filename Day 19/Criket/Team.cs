using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criket
{
    using System.Collections.Generic;

    public class Team
    {
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }
        public int TotalRuns { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
            Players = new List<Player>();
            TotalRuns = 0;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void UpdateTeamScore(int runs)
        {
            TotalRuns += runs;
        }
    }
}
