namespace DeckOfCards
{

    public enum Value { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

    public enum Suit { Diamonds, Clubs, Hearts, Spades }
    public class Card
    {
        private Value _value;
        private Suit _suit;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class with the specified value and suit.
        /// </summary>
        /// <param name="value">
        /// The value of the card (e.g., Ace, Two, etc.).
        /// </param>
        /// <param name="suit">
        /// The suit of the card (e.g., Diamonds, Clubs, etc.).
        /// </param>
        public Card(Value value, Suit suit)
        {
            _value = value;
            _suit = suit;
        }

        /// <summary>
        /// Gets the value of the card (e.g., Ace, Two, etc.).
        /// </summary>
        public Value Value { get => _value; }
        
        /// <summary>
        /// Gets the suit of the card (e.g., Diamonds, Clubs, etc.).
        /// </summary>
        public Suit Suit { get => _suit; }

        /// <summary>
        /// Returns the string representation of the card.
        /// </summary>
        /// <returns>A string in the format "<see cref="Value"/> of <see cref="Suit"/>".</returns>
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
