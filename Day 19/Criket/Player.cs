using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criket
{
    public class Player
    {
        public string Name { get; set; }
        public int Runs { get; set; }
        public int BallsFaced { get; set; }

        public Player(string name)
        {
            Name = name;
            Runs = 0;
            BallsFaced = 0;
        }

        public void ScoreRuns(int runs)
        {
            Runs += runs;
            BallsFaced++;
        }
    }
}

