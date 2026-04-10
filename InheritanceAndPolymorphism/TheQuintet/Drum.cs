namespace TheQuintet
{
	public class Drum : Instrument
	{
		/// <summary>
		/// Constructor for the Drum class.
		/// </summary>
		public Drum() : base() {}

		/// <summary>
		/// Overrides the Play method to play the drum.
		/// </summary>
		public override void Play()
		{
			Console.WriteLine("The drum is beating a rhythm.");
		}

		public override string ToString()
		{
			return "Description: A drum is a percussion instrument. The drum is usually cylindrical in shape. Skin or other elastic material is stretched over one end of the cylinder.";
		}
	}
}
