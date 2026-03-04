namespace TheGoldenSeagull
{
    public class Burger
    {
        private string _name;
        private double _price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Burger"/> class
        /// with the specified name and price.
        /// </summary>
        /// <param name="name">
        /// The name of the burger.
        /// </param>
        /// <param name="price">
        /// The price of the burger.
        /// </param>
        public Burger(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string Name { get => _name; }
        public double Price { get => _price; }

        public override string ToString()
        {
            return $"Burger: {Name}, Price: {Price}";
        }
    }
}
