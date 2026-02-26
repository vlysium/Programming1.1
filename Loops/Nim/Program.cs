namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // game state
            int matches = 16;
            int[] moves = { 1, 2, 3 };
            int userInput = 0;
            int computerInput = 0;

            bool isUsersTurn = random.Next(0, 2) == 1; // randomly choose who starts

            // start the game
            while (matches > 1)
            {
                Console.WriteLine($"{matches} matches left");
                Thread.Sleep(1000);

                if (isUsersTurn) {
                    // user's turn
                    Console.WriteLine("Enter amount of matches to remove (1, 2 or 3):");
                    userInput = Convert.ToByte(Console.ReadLine());

                    // handle illegal moves
                    while (!moves.Contains(userInput) || userInput > matches)
                    {
                        // user inputs illegal input
                        if (!moves.Contains(userInput))
                        {
                            Console.WriteLine("You can only remove 1, 2 or 3 matches");
                        }

                        // user removes more matches than exists
                        if (userInput >= matches)
                        {
                            Console.WriteLine($"You can't remove {userInput} matches when there are only {matches} matches left");
                        }

                        userInput = Convert.ToByte(Console.ReadLine());
                    }

                    Console.WriteLine($"You removed {userInput} matches");
                    matches -= userInput;
                    isUsersTurn = false;
                }
                else
                {
                    // computer's turn
                    int randomIndex = random.Next(0, moves.Length);
                    computerInput = moves[randomIndex];

                    // computer illegal move
                    while (computerInput >= matches)
                    {
                        computerInput = moves[randomIndex];
                    }

                    Console.WriteLine($"Computer removed {computerInput} matches");
                    matches -= computerInput;
                    isUsersTurn = true;
                }
            }

            // game finished
            if (isUsersTurn)
            {
                Console.WriteLine("Oh no, you lost!");
            }
            else
            {
                Console.WriteLine("Congratulations, you won!");
            }
        }
    }
}
