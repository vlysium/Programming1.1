namespace TurnTheLightsOff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turn the lights on and off! Type:");
            Console.WriteLine("\"on\" to turn lights on");
            Console.WriteLine("\"off\" to turn lights off");
            Console.WriteLine("\"quit\" to exit the program");

            string userInput = "";
            while (userInput != "quit")
            {
                userInput = Console.ReadLine();

                if (userInput == "on")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("The lights are now on");
                }

                if (userInput == "off")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The lights are now off");
                }

                Console.ResetColor();
            }
        }
    }
}
