namespace TheQuintet
{
	public class Saxophone : Instrument
	{
		/// <summary>
		/// Constructor for the Saxophone class.
		/// </summary>
		public Saxophone() : base() {}

		/// <summary>
		/// Overrides the Play method to play the saxophone.
		/// </summary>
		public override void Play()
		{
			Console.WriteLine("The saxophone is playing a smooth jazz tune.");
		}

		public override string ToString()
		{
			return "Description: A saxophone is a transposing woodwind instrument, although usually made of brass. It was invented in the 1840s by Belgian instrument maker Adolphe Sax";
		}
	}
}
