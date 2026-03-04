namespace TheGoldenSeagull
{
    /// <summary>
    /// The enum FriesSize is used to represent the cost of different fries sizes.
    /// </summary>
    public enum FriesSize
    {
        Medium = 24,
        Large = 33,
        ExtraLarge = 50
    }
    public class Fries
    {
        private double _price;
        private FriesSize _size;
        private bool _isSalted;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fries"/> class
        /// with the specified size and salted status.
        /// </summary>
        /// <param name="size">
        /// The <see cref="FriesSize"/> that determines both the portion size
        /// and the price of the fries.
        /// </param>
        /// <param name="isSalted">
        /// <c>true</c> if the fries are salted; otherwise, <c>false</c>.
        /// </param>
        /// <remarks>
        /// The price is automatically determined by casting the
        /// <paramref name="size"/> value to a <see cref="double"/>.
        /// </remarks>
        public Fries(FriesSize size, bool isSalted)
        {
            _price = (double)size;
            _size = size;
            _isSalted = isSalted;
        }

        public double Price { get => _price; }
        public FriesSize Size { get => _size; }
        public bool IsSalted { get => _isSalted; }

        public override string ToString()
        {
            return $"Price: {Price}, Size: {Size}, IsSalted: {IsSalted}";
        }
    }
}
