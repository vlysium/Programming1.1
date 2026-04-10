namespace TheQuintet;

public class Violin : BowString
{
	/// <summary>
	/// Initializes a new instance of the Violin class with the specified number of strings.
	/// </summary>
	/// <param name="numberOfStrings">The number of strings on the violin.</param>
	public Violin(int numberOfStrings) : base(numberOfStrings) { }

	/// <summary>
	/// Overrides the Play method to play the violin.
	/// </summary>
	public override void Play()
	{
		Console.WriteLine("The violin is playing a beautiful tune.");
	}

	public override string ToString()
	{
		return $"Description: The violin is a string instrument with four strings, tuned in fifths: G, D1, A1 and E2, where the A string is thus tuned in the chamber tone. Number of strings: {NumberOfStrings}.";
	}
}
