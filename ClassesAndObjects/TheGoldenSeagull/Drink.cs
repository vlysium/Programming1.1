namespace TheGoldenSeagull
{
    /// <summary>
    /// The enum DrinkSize is used to represent the cost of different drink sizes.
    /// </summary>
    public enum DrinkSize
    {
        Small = 13,
        Medium = 25,
        Large = 35
    }

    public class Drink
    {
        private string _name;
        private double _price;
        private DrinkSize _size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Drink"/> class
        /// with the specified name and size.
        /// </summary>
        /// <param name="name">
        /// The name of the drink.
        /// </param>
        /// <param name="size">
        /// The <see cref="DrinkSize"/> that determines both the portion size
        /// and the price of the drink.
        /// </param>
        /// <remarks>
        /// The price is automatically determined by casting the
        /// <paramref name="size"/> value to a <see cref="double"/>.
        /// </remarks>
        public Drink(string name, DrinkSize size)
        {
            _name = name;
            _price = (double)size;
            _size = size;
        }

        public string Name { get => _name; }
        public double Price { get => _price; }
        public DrinkSize Size { get => _size; }

        public override string ToString()
        {
            return $"Drink: {Name}, Price: {Price}, Size: {Size}";
        }
    }
}
