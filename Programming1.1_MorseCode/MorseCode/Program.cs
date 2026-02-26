namespace MorseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read input from user
            Console.WriteLine("Enter your text to convert to Morse code:");
            string userInput = Console.ReadLine();

            // lowercase text
            userInput = userInput.ToLower();

            // convert string to array of characters
            char[] characters = userInput.ToCharArray();

            // array of converted characters to morse code
            string[] morseCodeArray = new string[characters.Length];

            // convert each character to morse code
            for (int i = 0; i < characters.Length; i++)
            {
                string convertedMorseCode = ConvertCharToMorseCode(characters[i]);
                morseCodeArray[i] = convertedMorseCode;
            }

            // convert array of morse code into a string
            string morseCodeMessage = string.Join("/", morseCodeArray);

            // display the morse code
            Console.WriteLine(morseCodeMessage);

            // function to convert character to morse code
            string ConvertCharToMorseCode(char character)
            {
                switch (character)
                {
                    case 'a':
                        return ".-";

                    case 'b':
                        return "-...";

                    case 'c':
                        return "-.-.";

                    case 'd':
                        return "-..";

                    case 'e':
                        return "..-..";

                    case 'f':
                        return "..-.";

                    case 'g':
                        return "--.";

                    case 'h':
                        return "....";

                    case 'i':
                        return "..";

                    case 'j':
                        return ".---";

                    case 'k':
                        return "-.-";

                    case 'l':
                        return ".-..";

                    case 'm':
                        return "--";

                    case 'n':
                        return "-.";

                    case 'o':
                        return "---";

                    case 'p':
                        return ".--.";

                    case 'q':
                        return "--.-";

                    case 'r':
                        return ".-.";

                    case 's':
                        return "...";

                    case 't':
                        return "-";

                    case 'u':
                        return "..-";

                    case 'v':
                        return "...-";

                    case 'w':
                        return ".--";

                    case 'x':
                        return "-..-";

                    case 'y':
                        return "-.--";

                    case 'z':
                        return "--..";

                    case 'æ':
                        return ".-.-";

                    case 'ø':
                        return "---.";

                    case 'å':
                        return ".--.-";

                    case '1':
                        return ".----";

                    case '2':
                        return "..---";

                    case '3':
                        return "...--";

                    case '4':
                        return "....-";

                    case '5':
                        return ".....";

                    case '6':
                        return "-....";

                    case '7':
                        return "--...";

                    case '8':
                        return "---..";

                    case '9':
                        return "----.";

                    case '0':
                        return "-----";

                    default:
                        return "";

                }
            }
        }
    }
}
