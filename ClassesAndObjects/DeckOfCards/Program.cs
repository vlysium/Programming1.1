namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an array to hold 52 cards in the deck
            Card[] deck = new Card[52];

            // get all possible suits and values from the enums
            Suit[] suits = (Suit[])Enum.GetValues(typeof(Suit));
            Value[] values = (Value[])Enum.GetValues(typeof(Value));

            // populate the deck with cards by iterating through each suit and value
            int index = 0;
            foreach (Suit suit in suits)
            {
                foreach (Value value in values)
                {
                    deck[index] = new Card(value, suit);
                    index++;
                }
            }
            
            // display all the cards
            foreach (Card card in deck)
            {
                Console.WriteLine(card);
            }
        }
    }
}
