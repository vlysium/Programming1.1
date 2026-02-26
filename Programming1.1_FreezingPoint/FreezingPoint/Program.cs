namespace FreezingPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Please enter the temperature of your fridge in Celsius:");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // evaluate user input
            switch (userInput)
            {
                case > 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The temperature of your fridge is too hot! You should adjust the temperature immediately.");
                    break;

                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The temperature of your fridge is ideal! Please keep monitoring your fridge.");
                    break;

                case < 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The temperature of your fridge is good.");
                    break;

                default:
                    Console.WriteLine("Invalid temperature");
                    break;

            }

            Console.ResetColor();
        }
    }
}
