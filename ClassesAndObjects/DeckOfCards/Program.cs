namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Console.WriteLine("Welcome to the Deck of Cards program!");
            Console.WriteLine("Write \"display\" to see the deck of cards, \"shuffle\" to shuffle the deck, \"draw\" to draw a random card, or \"exit\" to quit the program.");
            string userInput = "";

            while (userInput != "exit")
            {
                Console.Write("Enter a command: ");
                userInput = Console.ReadLine()?.ToLower();

                switch (userInput)
                {
                    case "display":
                        deck.Display();
                        break;
                    case "shuffle":
                        deck.Shuffle();
                        Console.WriteLine("The deck has been shuffled.");
                        break;
                    case "draw":
                        Card drawnCard = deck.DrawCard();
                        Console.WriteLine($"You drew: {drawnCard}");
                        break;
                    case "exit":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            }
        }
    }
}
