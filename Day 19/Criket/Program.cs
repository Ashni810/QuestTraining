using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criket
{
    class Program
    {
        static void Main(string[] args)
        {
            Team playerTeam = new Team("Player Team");
            ComputerTeam computerTeam = new ComputerTeam("Computer Team");

            Console.WriteLine("Enter number of players in your team:");
            int playerCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= playerCount; i++)
            {
                Console.WriteLine($"Enter name for Player {i}:");
                string playerName = Console.ReadLine();
                playerTeam.AddPlayer(new Player(playerName));
            }

            // Adding computer players
            computerTeam.AddPlayer(new Player("Computer Player 1"));
            computerTeam.AddPlayer(new Player("Computer Player 2"));
            computerTeam.AddPlayer(new Player("Computer Player 3"));

            GameManager gameManager = new GameManager(playerTeam, computerTeam);
            gameManager.StartGame();
        }
    }
}
