namespace Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read user input
            Console.WriteLine("Enter your birthday (ddMMyyyy): ");
            string readin = Console.ReadLine();

            // parse input to DateTime
            DateTime birthday = DateTime.ParseExact(readin, "ddMMyyyy", null);

            // calculate difference in years
            TimeSpan timeDifference = DateTime.Now - birthday;
            int years = (int)Math.Floor(timeDifference.TotalDays / 365.2425);

            // calculate difference in days
            birthday = birthday.AddYears(years);
            TimeSpan daysDifference = DateTime.Now - birthday;
            int days = (int)Math.Floor(daysDifference.TotalDays);

            // print result
            Console.WriteLine($"You are {years} years and {days} old.");
        }
    }
}
