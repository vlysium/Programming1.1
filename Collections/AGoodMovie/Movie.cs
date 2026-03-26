namespace AGoodMovie
{
	public enum Genre { Action, Comedy, Drama, Horror, SciFi, Romance };

	public class Movie
	{
		private string _title;
		private Genre[] _genres;
		private int _yearOfPublication;
		private int _playingTimeInMinutes;
		private string _shortDescription;

		/// <summary>
		/// Gets or sets the title of the movie. The title is a string that represents the name of the movie.
		/// </summary>
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		/// <summary>
		/// Gets or sets the genres of the movie. The genres is an array of <see cref="Genre"/> enums that represent the categories of the movie.
		/// </summary>
		public Genre[] Genres
		{
			get { return (Genre[])_genres.Clone(); }
			set { _genres = (Genre[])value.Clone(); }
		}

		/// <summary>
		/// Gets or sets the year of publication of the movie.
		/// </summary>
		public int YearOfPublication
		{
			get { return _yearOfPublication; }
			set { _yearOfPublication = value; }
		}

		/// <summary>
		/// Gets or sets the playing time of the movie in minutes.
		/// </summary>
		public int PlayingTimeInMinutes
		{
			get { return _playingTimeInMinutes; }
			set { _playingTimeInMinutes = value; }
		}

		/// <summary>
		/// Gets or sets the short description of the movie.
		/// </summary>
		public string ShortDescription
		{
			get { return _shortDescription; }
			set { _shortDescription = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Movie"/> class with default values.
		/// The title is set to an empty string, genres is set to an empty array, year of publication
		/// and playing time are set to 0, and short description is set to an empty string.
		/// </summary>
		public Movie()
		{
			_title = string.Empty;
			_genres = new Genre[0];
			_yearOfPublication = 0;
			_playingTimeInMinutes = 0;
			_shortDescription = string.Empty;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Movie"/> class with the specified values for title, genres,
		/// year of publication, playing time in minutes, and short description. The genres array is cloned to ensure
		/// that the internal state of the movie is not affected by external changes to the array passed as an argument.
		/// </summary>
		/// <param name="title">
		/// The title of the movie.
		/// </param>
		/// <param name="genres">
		/// The genres of the movie.
		/// </param>
		/// <param name="yearOfPublication">
		/// The year of publication of the movie.
		/// </param>
		/// <param name="playingTimeInMinutes">
		/// The playing time of the movie in minutes.
		/// </param>
		/// <param name="shortDescription">
		/// The short description of the movie.
		/// </param>
		public Movie(string title, Genre[] genres, int yearOfPublication, int playingTimeInMinutes, string shortDescription) : this()
		{
			_title = title;
			_genres = (Genre[])genres.Clone();
			_yearOfPublication = yearOfPublication;
			_playingTimeInMinutes = playingTimeInMinutes;
			_shortDescription = shortDescription;
		}

		public override string ToString()
		{
			return $"{Title} ({YearOfPublication}) - {PlayingTimeInMinutes} minutes - Genres: {string.Join(", ", Genres)}\nDescription: {ShortDescription}";
		}
	}
}
