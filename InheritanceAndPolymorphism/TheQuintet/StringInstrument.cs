namespace TheQuintet
{
	public class StringInstrument : Instrument
	{
		private int _numberOfStrings;

		/// <summary>
		/// Gets and sets the number of strings on the string instrument.
		/// </summary>
		protected int NumberOfStrings
		{
			get { return _numberOfStrings; }
			private set { _numberOfStrings = value; }
		}

		/// <summary>
		/// Constructor for the StringInstrument class, which inherits from <see cref="Instrument"/>. It takes the number of strings as a parameter.
		/// </summary>
		/// <param name="numberOfStrings">The number of strings on the string instrument.</param>
		public StringInstrument(int numberOfStrings) : base()
		{
			_numberOfStrings = numberOfStrings;
		}

		public override void Play()
		{
			base.Play();
		}
		public override string ToString()
		{
			return $"Description: String instruments are instruments in which the sound is produced by string(s) that vibrate and produce sound, most often amplified by a sound box. Number of strings: {NumberOfStrings}.";
		}
	}
}
