namespace TheSpaceship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user inputs
            int userPopulation = GetPositiveInteger("What is the population of your country?");
            double userRate = GetPositiveDouble("What is the population growth in percentages of your country? (example: 1.5 = 1.5%)");
            int userYears = GetPositiveInteger("In how many years will your country evacuate the earth?");

            // calculate population growth
            int populationGrowth = GetPopulationGrowth(userPopulation, userRate, userYears);

            Console.WriteLine($"Your spaceship must be able to accomodate {populationGrowth} people for your population in {userYears} years.");
        }

        /// <summary>
        /// Prompts the user to enter a positive integer value using the specified message and returns the validated
        /// input.
        /// </summary>
        /// <remarks>
        /// The method repeatedly prompts the user until a valid positive integer greater than zero is entered. Input is
        /// read from the standard input stream.
        /// </remarks>
        /// <param name="message">The message to display to the user when prompting for input.</param>
        /// <returns>A positive integer value entered by the user.</returns>
        static int GetPositiveInteger(string message)
        {
            int value;

            Console.WriteLine(message);

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer greater than 0.");
            }

            return value;
        }

        /// <summary>
        /// Prompts the user to enter a positive double-precision floating-point number, displaying the specified
        /// message, and returns the validated input.
        /// </summary>
        /// <remarks>
        /// The method repeatedly prompts the user until a valid positive number is entered. Input is read from the
        /// standard input stream.
        /// </remarks>
        /// <param name="message">The message to display to the user when prompting for input.</param>
        /// <returns>A double value greater than 0 entered by the user.</returns>
        static double GetPositiveDouble(string message)
        {
            double value;

            Console.WriteLine(message);

            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number greater than 0.");
            }

            return value;
        }

        /// <summary>
        /// Calculates the projected population after a specified number of years, using a constant annual growth rate.
        /// </summary>
        /// <remarks>
        /// The calculation assumes compound growth with a constant rate applied each year. Negative values for
        /// population or years are not supported and may produce invalid results.
        /// </remarks>
        /// <param name="population">The initial population value. Must be a non-negative integer.</param>
        /// <param name="rate">
        /// The annual growth rate as a percentage. For example, 1.25 represents a 1.25% increase per year.
        /// </param>
        /// <param name="years">
        /// The number of years over which to project the population. Must be a non-negative integer.
        /// </param>
        /// <returns>
        /// The estimated population after the specified number of years, rounded up to the nearest whole number.
        /// </returns>
        static int GetPopulationGrowth(int population, double rate, int years)
        {
            double estimatedPopulation = population * Math.Pow(1 + (rate / 100), years);
            return (int)Math.Ceiling(estimatedPopulation);
        }
    }
}
