using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class SnakeAndLadderGame
    {
        static void Main(string[] args)
        {
            // Define the board size
            const int boardSize = 100;

            // Create a 1D array for the board
            int[] board = new int[boardSize + 1]; // 0 index will be unused

            // Define snakes and ladders
            // Snakes: from -> to
            board[16] = 6;
            board[47] = 26;
            board[49] = 11;
            board[56] = 53;
            board[62] = 19;
            board[64] = 60;
            board[87] = 24;
            board[93] = 73;
            board[95] = 75;
            board[98] = 78;

            // Ladders: from -> to
            board[1] = 38;
            board[4] = 14;
            board[9] = 31;
            board[21] = 42;
            board[28] = 84;
            board[36] = 44;
            board[51] = 67;
            board[71] = 91;
            board[80] = 100;

            // Initialize player positions
            int player1Position = 0;
            int player2Position = 0;
            Random random = new Random();
            int currentPlayer = 1;

            while (player1Position < boardSize && player2Position < boardSize)
            {
                Console.WriteLine($"Player {currentPlayer}'s turn. Press Enter to roll the die.");
                Console.ReadLine();
                int dieRoll = random.Next(1, 7); // Roll a die (1 to 6)
                Console.WriteLine($"Player {currentPlayer} rolled a {dieRoll}.");

                // Move the current player
                if (currentPlayer == 1)
                {
                    player1Position += dieRoll;
                    if (player1Position > boardSize) player1Position = boardSize; // Cap at 100
                    player1Position = board[player1Position] != 0 ? board[player1Position] : player1Position; // Check for snakes/ladders
                    Console.WriteLine($"Player 1 is now on square {player1Position}.");
                    if (player1Position >= boardSize)
                    {
                        Console.WriteLine("Player 1 wins!");
                        break;
                    }
                    currentPlayer = 2; // Switch to player 2
                }
                else
                {
                    player2Position += dieRoll;
                    if (player2Position > boardSize) player2Position = boardSize; // Cap at 100
                    player2Position = board[player2Position] != 0 ? board[player2Position] : player2Position; // Check for snakes/ladders
                    Console.WriteLine($"Player 2 is now on square {player2Position}.");
                    if (player2Position >= boardSize)
                    {
                        Console.WriteLine("Player 2 wins!");
                        break;
                    }
                    currentPlayer = 1; // Switch to player 1
                }
            }
        }
    }
}
