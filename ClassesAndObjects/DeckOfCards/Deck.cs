namespace DeckOfCards
{

    public class Deck
    {
        private readonly Card[] _cards;

        private readonly Random _random = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="Deck"/> class, populating it with 52 unique cards.
        /// </summary>
        public Deck()
        {
            _cards = new Card[52];
            Suit[] suits = (Suit[])Enum.GetValues(typeof(Suit));
            Value[] values = (Value[])Enum.GetValues(typeof(Value));

            int index = 0;
            foreach (Suit suit in suits)
            {
                foreach (Value value in values)
                {
                    _cards[index] = new Card(value, suit);
                    index++;
                }
            }
        }

        public Card[] Cards { get => _cards; }

        /// <summary>
        /// Displays all the cards in the deck by printing their string representations to the console.
        /// </summary>
        public void Display()
        {
            foreach (Card card in _cards)
            {
                Console.WriteLine(card);
            }
        }

        /// <summary>
        /// Shuffles the deck of cards using the Fisher-Yates algorithm, which ensures
        /// a uniform random distribution of the cards.
        /// </summary>
        public void Shuffle()
        {
            // backwards loop
            for (int i = _cards.Length - 1; i > 0; i--)
            {
                // swap Cards[i] with Cards[j]
                int j = _random.Next(0, i + 1);
                Card temp = _cards[i]; // store the current card in a temporary variable
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }

        /// <summary>
        /// Draws a random card from the deck by selecting a random index and returning
        /// the card at that index.
        /// </summary>
        /// <returns>A randomly selected card from the deck.</returns>
        public Card DrawCard()
        {
            return _cards[_random.Next(_cards.Length)];
        }
    }
}
