namespace PiggyBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // amount of money the user deposits
            Console.WriteLine("Enter the amount of money you want to deposit:");
            double userDeposit = Convert.ToDouble(Console.ReadLine());

            // interest rate
            Console.WriteLine("Enter the interest rate in whole numbers:");
            byte userInterest = Convert.ToByte(Console.ReadLine());

            // years to keep deposit
            Console.WriteLine("Enter how many years you want your money deposited in whole numbers:");
            byte userYears = Convert.ToByte(Console.ReadLine());

            // calculate money in the bank
            int year = 0;
            double CalculateMoney(double money)
            {
                // recursion
                while (year < userYears)
                {
                    double amount = money * (1 + (userInterest * 0.01));
                    year++;
                    Console.WriteLine($"Year {year}: {Math.Round(amount, 2)}");
                    CalculateMoney(amount);
                }
                return money;
            }

            CalculateMoney(userDeposit);
        }
    }
}

