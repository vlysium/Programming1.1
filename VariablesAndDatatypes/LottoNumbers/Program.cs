namespace LottoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            int delay = 2000;

            List<int> numbersUsed = [];

            int RandomNumber()
            {
                // generate random number between 1 and 36 that is not already used
                while (true)
                {
                    int number = random.Next(1, 37);
                    if (!numbersUsed.Contains(number))
                    {
                        numbersUsed.Add(number);
                        return number;
                    }
                }
            }

            // repeat 7 times
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(delay);
                Console.Write($"{RandomNumber()} ");
            }

            // joker number
            Thread.Sleep(delay);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{RandomNumber()}");
            Console.ResetColor();
        }
    }
}

