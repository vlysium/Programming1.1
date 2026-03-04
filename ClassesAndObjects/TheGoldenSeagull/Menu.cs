namespace TheGoldenSeagull
{
    public class Menu
    {
        private Burger _burger;
        private Drink _drink;
        private Fries _fries;


        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class
        /// with the specified burger, drink, and fries.
        /// </summary>
        /// <param name="burger">
        /// The <see cref="Burger"/> included in the menu.
        /// </param>
        /// <param name="drink">
        /// The <see cref="Drink"/> included in the menu.
        /// </param>
        /// <param name="fries">
        /// The <see cref="Fries"/> included in the menu.
        /// </param>
        public Menu(Burger burger, Drink drink, Fries fries)
        {
            _burger = burger;
            _drink = drink;
            _fries = fries;
        }

        public Burger Burger { get => _burger; }
        public Drink Drink { get => _drink; }
        public Fries Fries { get => _fries; }

        /// <summary>
        /// Calculates the total price of the menu by summing the prices
        /// of the <see cref="Burger"/>, <see cref="Drink"/>, and <see cref="Fries"/>.
        /// </summary>
        /// <returns>
        /// The combined price of all items in the menu.
        /// </returns>
        public double GetTotalPrice()
        {
            return Burger.Price + Drink.Price + Fries.Price;
        }

        public override string ToString()
        {
            return $"Burger: {Burger}, drink: {Drink}, fries: {Fries}";
        }
    }
}
