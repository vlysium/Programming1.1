namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moves = { "rock", "paper", "scissors" };
            string userInput = "";
            string chosenMove = "";

            // the game begins
            while (userInput == chosenMove)
            {
                // user picks a move
                Console.WriteLine($"Choose your move: {string.Join(", ", moves)}");
                userInput = Console.ReadLine().ToLower();

                // illegal move
                while (!moves.Contains(userInput))
                {
                    Console.WriteLine("Illegal move!");
                    userInput = Console.ReadLine().ToLower();
                }

                // random move by the computer
                Random random = new Random();
                int randomNumber = random.Next(0, moves.Length);
                chosenMove = moves[randomNumber];

                // print game phrase
                Thread.Sleep(500);
                Console.Write("Rock");
                Thread.Sleep(500);
                Console.Write(", paper");
                Thread.Sleep(500);
                Console.Write(", scissors");
                Thread.Sleep(500);
                Console.Write(", shoot!\n");

                // show moves
                Console.WriteLine($"Your move: {userInput} - computer's move: {chosenMove}");

                // evaluate game
                Thread.Sleep(500);

                // winning game states
                if (userInput == "rock" && chosenMove == "scissors")
                {
                    Console.WriteLine("Rock beats scissors. You win!");
                }

                if (userInput == "paper" && chosenMove == "rock")
                {
                    Console.WriteLine("Paper beats rock. You win!");
                }

                if (userInput == "scissors" && chosenMove == "paper")
                {
                    Console.WriteLine("Scissors beat paper. You win!");
                }

                // losing game states
                if (userInput == "rock" && chosenMove == "paper")
                {
                    Console.WriteLine("Paper beats rock. You lose!");
                }

                if (userInput == "paper" && chosenMove == "scissors")
                {
                    Console.WriteLine("Scissors beat paper. You lose!");
                }

                if (userInput == "scissors" && chosenMove == "rock")
                {
                    Console.WriteLine("Rock beats scissors. You lose!");
                }

                // tie game state
                if (userInput == chosenMove)
                {
                    Console.WriteLine("It's a tie. Try again!");
                }
            }
        }
    }
}

