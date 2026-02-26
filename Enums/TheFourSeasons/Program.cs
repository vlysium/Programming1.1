namespace TheFourSeasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user month
            Console.WriteLine("Enter a month:");
            string userMonth = Console.ReadLine();

            // display season
            string season = Convert.ToString(FindSeason(userMonth));
            Console.WriteLine(season);
        }
        public enum Seasons { Spring, Summer, Autumn, Winter }

        /// <summary>
        /// Determines the season associated with the specified month name.
        /// </summary>
        /// <param name="month">
        /// The name of the month for which to find the corresponding season. The value is case-insensitive and must be
        /// a valid month name in English.
        /// </param>
        /// <returns>A value from the Seasons enumeration representing the season for the specified month.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the value of <paramref name="month"/> is not a recognized month name.
        /// </exception>
        public static Seasons FindSeason(string month)
        {
            month = month.ToLower();

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    return Seasons.Spring;

                case "june":
                case "july":
                case "august":
                    return Seasons.Summer;

                case "september":
                case "october":
                case "november":
                    return Seasons.Autumn;

                case "december":
                case "january":
                case "february":
                    return Seasons.Winter;

                default: // suggested by copilot
                    throw new ArgumentException("Invalid month", nameof(month));
            }
        }
    }
}
