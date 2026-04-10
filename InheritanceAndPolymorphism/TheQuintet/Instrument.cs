namespace TheQuintet
{
	public abstract class Instrument
	{
		/// <summary>
		/// Constructor for the Instrument class. Since this is an abstract class, it cannot
		/// be instantiated directly, but it can be called from derived classes.
		/// </summary>
		public Instrument() {}

		/// <summary>
		/// Plays the instrument, playing a sound that is specific to the type of instrument.
		/// </summary>
		public virtual void Play()
		{
			Console.WriteLine("The instrument is being played.");
			//TODO: Implement `NAudio` to play the sound of the instrument
		}

		public override string ToString()
		{
			return "Description: A music instrument is an object, that can be played by a musician to play music.";
		}
	}
}
