namespace TheQuintet;

public class Piano : StringInstrument
{
	/// <summary>
	/// Initializes a new instance of the Piano class with the specified number of strings.
	/// </summary>
	/// <param name="numberOfStrings">The number of strings on the piano.</param>
	public Piano(int numberOfStrings) : base(numberOfStrings) { }

	/// <summary>
	/// Overrides the Play method to play the piano.
	/// </summary>
	public override void Play()
	{
		Console.WriteLine("The piano is playing a beautiful tune.");
	}

	public override string ToString()
	{
		return $"Description: A piano is a musical instrument that, together with the grand piano, is also called a piano (short form of pianoforte - Italian for \"quietly powerful\"). A piano consists of a keyboard that uses keys to cause felt-covered hammers to strike tuned strings. Number of strings: {NumberOfStrings}.";
	}
}
