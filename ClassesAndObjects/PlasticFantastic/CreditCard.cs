namespace PlasticFantastic
{
    /// <summary>
    /// CardType is an enum that represents the type of credit card. It can be <see cref="Visa"/>, <see cref="MasterCard"/>, <see cref="Dankort"/>, or <see cref="AmericanExpress"/>.
    /// </summary>
    public enum CardType { Visa, MasterCard, Dankort, AmericanExpress }

    public class CreditCard
    {
        private readonly string _cardNumber;
        private readonly CardType _cardType;
        private readonly double _creditLimit = 0.0;
        private readonly string _cardHolderName = "Unknown";

        /// <summary>
        /// This is a constructor for the CreditCard class. It takes in a card number and a card type, and sets the corresponding fields.
        /// </summary>
        /// <param name="cardNumber">
        /// The card number of the credit card.
        /// </param>
        /// <param name="cardType">
        /// The type of the credit card. See <see cref="CardType"/> for possible values.
        /// </param>
        public CreditCard(string cardNumber, CardType cardType)
        {
            _cardNumber = cardNumber;
            _cardType = cardType;
        }

        /// <inheritdoc cref="CreditCard(string, CardType)"/>
        /// <param name="creditLimit">
        /// The credit limit of the credit card.
        /// </param>
        public CreditCard(string cardNumber, CardType cardType, double creditLimit) : this(cardNumber, cardType)
        {
            _creditLimit = creditLimit;
        }

        /// <inheritdoc cref="CreditCard(string, CardType, double)"/>
        /// <param name="cardHolderName">
        /// The name of the card holder.
        /// </param>
        public CreditCard(string cardNumber, CardType cardType, double creditLimit, string cardHolderName) : this(cardNumber, cardType, creditLimit)
        {
            _cardHolderName = cardHolderName;
        }

        public string CardNumber { get => _cardNumber; }
        public CardType CardType { get => _cardType; }
        public double CreditLimit { get => _creditLimit; }
        public string CardHolderName { get => _cardHolderName; }

        public override string ToString()
        {
            return $"Card Number: {CardNumber}, Card Type: {CardType}, Credit Limit: {CreditLimit}, Card Holder Name: {CardHolderName}";
        }
    }
}
