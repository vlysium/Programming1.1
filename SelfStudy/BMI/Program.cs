namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user weight input
            Console.WriteLine("Enter your weight in kg");
            double weight = Convert.ToDouble(Console.ReadLine());

            // user height input
            Console.WriteLine("Enter your hight in m");
            double height = Convert.ToDouble(Console.ReadLine());

            // calculate bmi
            double bmi = Math.Round(weight / Math.Pow(height, 2), 2);

            // determine bmi category
            switch (bmi)
            {
                case < 18.5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You are underweight");
                    break;

                case >= 18.5 and < 24:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You have a normal weight");
                    break;

                case >= 24 and < 30:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are overweight");
                    break;

                case >= 30 and < 35:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You are first degree obese");
                    break;

                case >= 35 and < 40:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You are first second obese");
                    break;

                case >= 40:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are second third obese");
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;

            }

            Console.WriteLine($"Your bmi is {bmi}");

            Console.ResetColor();
        }
    }
}

