namespace Scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read user input
            Console.WriteLine("Enter a word:");
            string userInput = Console.ReadLine().ToLower();

            // points
            int points = 0;

            // iterate characters in word
            for (int i = 0; i < userInput.Length; i++)
            {
                char letter = userInput[i];
                CalculatePoints(letter);
            }

            // display points
            Console.WriteLine($"Your word {userInput} is worth {points} points");

            // calculate points
            int CalculatePoints(char letter)
            {
                if ("eanr".Contains(letter))
                {
                    return points += 1;
                }
                if ("dlost".Contains(letter))
                {
                    return points += 2;
                }
                if ("bikfgmuv".Contains(letter))
                {
                    return points += 3;
                }
                if ("hjpyæøå".Contains(letter))
                {
                    return points += 4;
                }
                if ("cxzwq".Contains(letter))
                {
                    return points += 8;
                }
                // any illegal chars
                return points;
            }
        }
    }
}
