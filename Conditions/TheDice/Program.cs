namespace TheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generate a random number between 1 and 6
            Random random = new Random();
            int diceRoll = random.Next(1, 7);

            switch (diceRoll)
            {
                case 1:
                    Console.WriteLine("You rolled a one!");
                    break;

                case 2:
                    Console.WriteLine("You rolled a two!");
                    break;

                case 3:
                    Console.WriteLine("You rolled a three!");
                    break;

                case 4:
                    Console.WriteLine("You rolled a four!");
                    break;

                case 5:
                    Console.WriteLine("You rolled a five!");
                    break;

                case 6:
                    Console.WriteLine("You rolled a six!");
                    break;

                default:
                    Console.WriteLine("Invalid roll.");
                    break;
            }
        }
    }
}

