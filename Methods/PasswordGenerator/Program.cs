namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // possible characters
            string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string specialCharacters = "!@#$%&";

            // initiate an empty array for adding characters and shuffling later
            List<char> passwordArray = [];

            // generate 6 random lowercase letters
            for (int i = 0; i < 6; i++)
            {
                char character = SelectRandomCharacter(lowercaseLetters);
                passwordArray.Add(character);
            }

            // generate 6 random lowercase letters
            for (int i = 0; i < 6; i++)
            {
                char character = SelectRandomCharacter(uppercaseLetters);
                passwordArray.Add(character);
            }

            // generate 6 random numbers
            for (int i = 0; i < 6; i++)
            {
                char character = SelectRandomCharacter(numbers);
                passwordArray.Add(character);
            }

            // generate 2 random special characters
            for (int i = 0; i < 2; i++)
            {
                char character = SelectRandomCharacter(specialCharacters);
                passwordArray.Add(character);
            }

            // shuffle the password array and convert to string
            string generatedPassword = string.Join("", passwordArray.Shuffle());

            // display the generated password to the user
            Console.Write("Here is your randomly generated 20 characters long password: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(generatedPassword);
            Console.ResetColor();
            Console.Write(", please keep it safe!");
        }

        /// <summary>
        /// Selects a random character from the specified array of characters.
        /// </summary>
        /// <param name="characters">An array of characters to choose from. Must not be null or empty.</param>
        /// <returns>A randomly selected character from the <paramref name="characters"/> array.</returns>
        static char SelectRandomCharacter(string characters)
        {
            Random random = new Random();
            int randomCharacterIndex = random.Next(characters.Length);
            char randomCharacter = characters[randomCharacterIndex];
            return randomCharacter;
        }
    }
}
