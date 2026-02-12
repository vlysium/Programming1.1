namespace HeadsOrTails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generate a random number between 0 and 1
            Random random = new Random();
            int generateCoinflip = random.Next(0, 2);

            // assign heads or tails to the random number
            string coinflip;
            if (generateCoinflip == 0)
            {
                coinflip = "heads";
            }
            else
            {
                coinflip = "tails";
            }

            // ask the user to guess the coin flip result
            Console.WriteLine("Guess the coin flip result! Type \"heads\" or \"tails\":");
            string userInput = Console.ReadLine();

            // check if the user guessed correctly
            if ((userInput == coinflip) || (userInput == coinflip))
            {
                Console.WriteLine($"You won! The coin landed on {coinflip}");
            }
            else
            {
                Console.WriteLine($"You lost! The coin landed on {coinflip}");
            }
        }
    }
}

