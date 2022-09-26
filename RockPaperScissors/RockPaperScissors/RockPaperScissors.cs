using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main()
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            string computerMove = "";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("Chose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again ...");
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);


            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"The computer chose {computerMove}.");
            if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win.");
            }
            else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game was a draw.");
            }
        }
    }
}
