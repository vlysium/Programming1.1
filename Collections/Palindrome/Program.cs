namespace Palindrome
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a word or sentence to check if it's a palindrome.");
			Console.Write("Input: ");
			string? userInput = Console.ReadLine();

			if (IsPalindrome(userInput))
			{
				Console.WriteLine($"\"{userInput}\" is a palindrome.");
			}
			else
			{
				Console.WriteLine($"\"{userInput}\" is not a palindrome.");
			}
		}

		/// <summary>
		/// Checks if the given string is a palindrome, ignoring non-alphanumeric characters and case.
		/// </summary>
		/// <param name="myString">The string to check. Can be a word or a sentence.</param>
		/// <returns>true if the string is a palindrome, false if otherwise.</returns>
		public static bool IsPalindrome(string? myString)
		{
			// Return false if the string is null or empty
			if (string.IsNullOrEmpty(myString)) return false;

			// Create a stack to hold the characters of the string
			Stack<char> stack = new Stack<char>();

			// Remove non-alphanumeric characters
			myString = new string(myString.Where(char.IsLetterOrDigit).ToArray());

			// Convert to lowercase for case-insensitive comparison
			myString = myString.ToLower();

			// Push all characters into the stack
			foreach(char character in myString)
			{
				stack.Push(character);
			}

			// Compare letters
			foreach(char character in myString)
			{
				char lastCharacter = stack.Pop();

				// Return false if a mismatch is found
				if (!character.Equals(lastCharacter)) return false;
			}

			return true;
		}
	}
}
