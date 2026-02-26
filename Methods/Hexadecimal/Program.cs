using System.Text.RegularExpressions;

namespace Hexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            Console.WriteLine("Enter a hexadecimal color starting with \"#\"");

            while (ValidateHexadecimal(userInput) != userInput)
            {
                userInput = Console.ReadLine();
                string error = ValidateHexadecimal(userInput);

                Console.WriteLine(error);
            }

            Console.WriteLine("Your hexadecimal value is valid");
        }

        /// <summary>
        /// Validates whether the specified string is a valid hexadecimal color code in the format "#RRGGBB" and returns
        /// an error message if the value is invalid.
        /// </summary>
        /// <remarks>
        /// The method performs a case-insensitive validation and expects the input to be in the format "#RRGGBB". If
        /// the input does not meet the required format, a descriptive error message is returned instead of the original
        /// value.
        /// </remarks>
        /// <param name="value">
        /// The string to validate as a hexadecimal color code. The value should begin with a '#' character followed by
        /// 3 to 6 hexadecimal digits (0-9, a-f or A-F).
        /// </param>
        /// <returns>
        /// The original value if it is a valid hexadecimal color code; otherwise, a string describing the validation
        /// error.
        /// </returns>
        static string ValidateHexadecimal(string value)
        {
            value = value.ToLower();

            // length is greater than 7
            if (value.Length > 7)
            {
                return "Too many digits"; 
            }

            // length is smaller than 4
            if (value.Length < 4)
            {
                return "Too few digits";
            }

            // first character isn't "#"
            if (!value.StartsWith('#'))
            {
                return "Missing \"#\" at the start";
            }

            // last 6 digits contain invalid digits 0-9 and a-f
            if (!Regex.IsMatch(value.Substring(1), "^[a-f0-9]+$"))
            {
                return "Contains invalid digits";
            }

            return value;
        }
    }
}
