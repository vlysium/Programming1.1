namespace TheQuintet
{
	public class BowString : StringInstrument
	{
		/// <summary>
		/// Constructor for BowString class, which inherits from <see cref="StringInstrument"/>. It takes the number of strings as a parameter and passes it to the base class constructor.
		/// </summary>
		/// <param name="numberOfStrings">The number of strings on the bow string instrument.</param>
		public BowString(int numberOfStrings) : base(numberOfStrings) { }

		public override void Play()
		{
			base.Play();
		}

		public override string ToString()
		{
			return $"Description: A bow string instrument is a stringed instrument played with a wooden bow, on which horsehair is stretched and rubbed with resin. Number of strings: {NumberOfStrings}.";
		}
	}
}
