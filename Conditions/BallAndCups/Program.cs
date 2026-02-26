namespace BallAndCups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generate a random number between 1 and 3 to represent the cup hiding the ball
            Random random = new Random();
            int ballPosition = random.Next(1, 4);

            // graphic representation of cups
            Console.WriteLine("Guess which cup the ball is hidden inside (1, 2, 3)");
            Console.WriteLine("  _._     _._     _._  ");
            Console.WriteLine(" | # |   | # |   | # | ");
            Console.WriteLine(" | 1 |   | 2 |   | 3 | ");
            Console.WriteLine(" |___|   |___|   |___| ");

            // user input
            int userGuess = Convert.ToInt16(Console.ReadLine());

            // check if the user guessed correctly
            if (userGuess == ballPosition)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
            }
            else
            {
                Console.WriteLine($"Sorry, the ball was under cup {ballPosition}. Better luck next time!");
            }
        }
    }
}
