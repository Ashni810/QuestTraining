using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string[] choices = { "Rock", "Paper", "Scissors" };
        int userScore = 0;
        int computerScore = 0;

        while (userScore < 10 && computerScore < 10)
        {
            Console.WriteLine($"Enter\n 1 for Rock\n 2 for Paper\n 3 for Scissors");
            int userInput;
            bool validInput = int.TryParse(Console.ReadLine(), out userInput);

            if (!validInput || userInput < 1 || userInput > 3)
            {
                Console.WriteLine("Invalid input, please try again.");
                continue;
            }

            string userChoice = choices[userInput - 1];
            string computerChoice = choices[random.Next(choices.Length)];

            Console.WriteLine($"You chose: {userChoice}");
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                (userChoice == "Rock" && computerChoice == "Scissors") ||
                (userChoice == "Paper" && computerChoice == "Rock") ||
                (userChoice == "Scissors" && computerChoice == "Paper")
            )
            {
                Console.WriteLine("You win this round!");
                userScore++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computerScore++;
            }

            Console.WriteLine($"Score - You: {userScore}, Computer: {computerScore}");
        }

        if (userScore == 10)
        {
            Console.WriteLine("Congratulations! You won the game!");
        }
        else
        {
            Console.WriteLine("Computer won the game. Better luck next time!");
        }
    }
}
