namespace GuessTheColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // possible colors
            string[] colors = { "red", "orange", "yellow", "green", "blue", "violet" };

            // select a random color
            Random random = new Random();
            int randomNumber = random.Next(0, colors.Length);
            string chosenRandomColor = colors[randomNumber];

            // game state
            int maxAttempts = 3;
            bool hasWon = false;

            // begin game
            Console.WriteLine($"Guess the correct color! You have max {maxAttempts} attempts.");
            Console.WriteLine($"Possible colors: {string.Join(", ", colors)}");

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                // user guess
                Console.WriteLine($"Attempt number {attempt}:");
                string userGuess = Console.ReadLine().ToLower();

                // correct guess
                if (userGuess == chosenRandomColor)
                {
                    hasWon = true;
                    Console.WriteLine("Congratulations, you won!");
                    return;
                }

                // incorrect guess
                Console.WriteLine("Incorrect guess! Try again.");
            }

            // user lost
            if (!hasWon)
            {
                Console.WriteLine($"You have used up all your guesses. The correct answer was {chosenRandomColor}. Better luck next time!");
            }
        }
    }
}
