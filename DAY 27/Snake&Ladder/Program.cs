using System;
class Program
{
    static void Main()
    {
        int[] board = new int[101]; // 0 index not used
        InitializeBoard(board);

        int player1Position = 1;
        int player2Position = 1;
        Random random = new Random();

        while (true)
        {
            // Player 1's turn
            Console.WriteLine("Player 1, press Enter to roll the die.");
            Console.ReadLine();
            player1Position = MovePlayer(player1Position, random);
            player1Position = ApplySnakesAndLadders(player1Position, board);
            Console.WriteLine($"Player 1 is now on square {player1Position}");
            if (player1Position >= 100)
            {
                Console.WriteLine("Player 1 wins!");
                break;
            }

            // Player 2's turn
            Console.WriteLine("Player 2, press Enter to roll the die.");
            Console.ReadLine();
            player2Position = MovePlayer(player2Position, random);
            player2Position = ApplySnakesAndLadders(player2Position, board);
            Console.WriteLine($"Player 2 is now on square {player2Position}");
            if (player2Position >= 100)
            {
                Console.WriteLine("Player 2 wins!");
                break;
            }
        }
    }

    static void InitializeBoard(int[] board)
    {
        // Initialize snakes
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

        // Initialize ladders
        board[1] = 38;
        board[4] = 14;
        board[9] = 31;
        board[21] = 42;
        board[28] = 84;
        board[36] = 44;
        board[51] = 67;
        board[71] = 91;
        board[80] = 100;
    }

    static int MovePlayer(int position, Random random)
    {
        int roll = random.Next(1, 7);
        Console.WriteLine($"Rolled a {roll}");
        position += roll;
        if (position > 100)
        {
            position = 100;
        }
        return position;
    }

    static int ApplySnakesAndLadders(int position, int[] board)
    {
        if (board[position] != 0)
        {
            Console.WriteLine($"Player encounters a {(board[position] > position ? "Ladder" : "Snake")} from {position} to {board[position]}");
            position = board[position];
        }
        return position;
    }
}
