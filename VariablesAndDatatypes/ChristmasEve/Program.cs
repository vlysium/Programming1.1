namespace ChristmasEve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate days until Christmas Eve (ddMMyyyy)");

            // read date from user
            string userInput = Console.ReadLine();

            DateTime date = DateTime.ParseExact(userInput, "ddMMyyyy", null);

            // get year from date
            int year = date.Year;

            // create date for 24th December of that year
            DateTime christmasEve = new DateTime(year, 12, 24);

            // calculate days until christmas eve
            int daysUntilChristmasEve = (christmasEve - date).Days;

            // if christmas eve has passed this year, set date to next year's christmas eve
            if (daysUntilChristmasEve < 0)
            {
                daysUntilChristmasEve = (christmasEve.AddYears(1) - date).Days;
            }

            Console.WriteLine($"{daysUntilChristmasEve} days until Christmas Eve");
        }
    }
}

