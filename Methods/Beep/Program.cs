namespace Beep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get count
            int userCount = GetPositiveInteger("How many times should the alarm go off?");

            // get delay
            int userDelay = GetPositiveInteger("How often should the alarm go off in milliseconds?");

            Beep(userCount, userDelay);
        }

        /// <summary>
        /// Prompts the user to enter a positive integer value using the specified message and returns the validated
        /// input.
        /// </summary>
        /// <remarks>The method repeatedly prompts the user until a valid positive integer is entered.
        /// Input is read from the standard input stream.</remarks>
        /// <param name="message">The message displayed to the user when prompting for input.</param>
        /// <returns>A positive integer value entered by the user.</returns>
        static int GetPositiveInteger(string message)
        {
            int value;

            Console.WriteLine(message);

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0) // validate user input
            {
                Console.WriteLine("Invalid input. Please enter a positive integer greater than 0.");
            }

            return value;
        }

        /// <summary>
        /// Writes the word "BEEP!" to the console the specified number of times, with a delay between each output.
        /// </summary>
        /// <remarks>The console text color is set to black on yellow for the duration of the output and
        /// is reset afterward. If count is zero, no output is written.</remarks>
        /// <param name="count">The number of times to write "BEEP!" to the console. Must be zero or greater.</param>
        /// <param name="delay">The delay, in milliseconds, to wait between each output. Must be zero or greater.</param>
        static void Beep(int count, int delay)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < count; i++)
            {
                // add a space between each "BEEP!"
                if (i != 0)
                {
                    Console.Write(" ");
                }
                Console.Write("BEEP!");

                Thread.Sleep(delay);
            }

            Console.ResetColor();
        }
    }
}
