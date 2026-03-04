namespace TheGoldenSeagull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // start
            Console.WriteLine("Welcome to The Golden Seagull!");
            
            // get user drink name
            Console.WriteLine("What would you like for your drink?");
            Console.Write("Drink name: ");
            string userDrinkName = Console.ReadLine();

            // get user drink size
            Console.WriteLine($"What size would you like your {userDrinkName} drink to be?");
            Console.WriteLine("(Type \"s\" for small, \"m\" for medium, \"l\" for large)");
            DrinkSize userDrinkSize;
            string userDrinkSizeInput = "";

            while (true)
            {
                Console.Write("Drink size: ");
                userDrinkSizeInput = Console.ReadLine();
                userDrinkSizeInput = userDrinkSizeInput.ToLower();

                switch (userDrinkSizeInput)
                {
                    case "s":
                        userDrinkSize = DrinkSize.Small;
                        break;

                    case "m":
                        userDrinkSize = DrinkSize.Medium;
                        break;
                    
                    case "l":
                        userDrinkSize = DrinkSize.Large;
                        break;

                    default:
                        Console.WriteLine("Invalid drink size");
                        continue;
                }

                break;
            }

            // instantiate user drink
            Drink userDrink = new Drink(userDrinkName, userDrinkSize);

            // get user fries size
            Console.WriteLine("What size would you like your fries");
            Console.WriteLine("(Type \"m\" for medium, \"l\" for large, \"xl\" for extra large)");
            FriesSize userFriesSize;
            string userFriesSizeInput = "";

            while (true)
            {
                Console.Write("Fries size: ");
                userFriesSizeInput = Console.ReadLine();
                userFriesSizeInput = userFriesSizeInput.ToLower();

                switch (userFriesSizeInput)
                {
                    case "m":
                        userFriesSize = FriesSize.Medium;
                        break;

                    case "l":
                        userFriesSize = FriesSize.Large;
                        break;
                    
                    case "xl":
                        userFriesSize = FriesSize.ExtraLarge;
                        break;

                    default:
                        Console.WriteLine("Invalid fries size");
                        continue;
                }

                break;
            }

            // get salted fries preference
            Console.WriteLine("Would you like your fries salted?");
            Console.WriteLine("(Type \"y\" for yes, \"n\" for no)");
            bool userFriesIsSalted;
            string userFriesIsSaltedInput = "";

            while (true)
            {
                Console.Write("Salted fries: ");
                userFriesIsSaltedInput = Console.ReadLine();
                userFriesIsSaltedInput = userFriesIsSaltedInput.ToLower();

                switch (userFriesIsSaltedInput)
                {
                    case "y":
                        userFriesIsSalted = true;
                        break;

                    case "n":
                        userFriesIsSalted = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        continue;
                }

                break;
            }

            // instantiate user fries
            Fries userFries = new Fries(userFriesSize, userFriesIsSalted);

            // get user burger name
            Console.WriteLine("What kind of burger would you like?");
            Console.Write("Burger name: ");
            string userBurgerName = Console.ReadLine();

            // get user burger price
            Console.WriteLine($"What is the price of your {userBurgerName} burger?");
            Console.Write("Burger price: ");
            double userBurgerPrice = Convert.ToDouble(Console.ReadLine()); //TODO: input validation

            // instantiate user burger
            Burger userBurger = new Burger(userBurgerName, userBurgerPrice);

            // instantiate user menu
            Menu userMenu = new Menu(userBurger, userDrink, userFries);

            // get total cost
            Console.WriteLine($"Your total cost is: {userMenu.GetTotalPrice()}");
        }
    }
}
