namespace TheQuintet;

public class Guitar : StringInstrument
{
	/// <summary>
	/// Initializes a new instance of the Guitar class with the specified number of strings.
	/// </summary>
	/// <param name="numberOfStrings">The number of strings on the guitar.</param>
	public Guitar(int numberOfStrings) : base(numberOfStrings) { }

	/// <summary>
	/// Overrides the Play method to play the guitar.
	/// </summary>
	public override void Play()
	{
		Console.WriteLine("The guitar is strumming a melody.");
	}

	public override string ToString()
	{
		return $"Description: The guitar is a plucked string instrument usually with six strings, but four, seven, eight, nine, ten or 12 (double chorus) are also found. The original form is acoustic with a body that forms a resonant base for the vibrations of the strings. Number of strings: {NumberOfStrings}.";
	}
}
