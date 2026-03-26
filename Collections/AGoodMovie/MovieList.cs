namespace AGoodMovie
{

	public class MovieList
	{
		private List<Movie> _movies;

		/// <summary>
		/// Gets the list of movies in the movie list.
		/// </summary>
		public List<Movie> Movies {
			get { return _movies; }
		}

		/// <summary>
		/// Initializes a new instance of the MovieList class with an empty list of movies.
		/// </summary>
		public MovieList()
		{
			_movies = new List<Movie>();
		}

		/// <summary>
		/// Adds a movie to the movie list.
		/// </summary>
		/// <param name="movie">The movie to add.</param>
		public void Add(Movie movie)
		{
			_movies.Add(movie);
		}

		/// <summary>
		/// Removes a movie from the movie list.
		/// </summary>
		/// <param name="movie">The movie to remove.</param>
		/// <returns>The removed movie.</returns>
		public Movie Remove(Movie movie)
		{
			_movies.Remove(movie);
			return movie;
		}

		/// <summary>
		/// Finds a movie in the movie list by its title. Returns the movie if found, or null if not found.
		/// </summary>
		/// <param name="title">The title of the movie to find.</param>
		/// <returns>The found movie or null if not found.</returns>
		public Movie? FindByTitle(string title)
		{
			foreach (Movie movie in _movies)
			{
				if (movie.Title.Equals(title, StringComparison.CurrentCultureIgnoreCase))
				{
					return movie;
				}
			}
			return null;
		}

		/// <summary>
		/// Finds movies in the movie list by a specified genre. Returns an array of
		/// movies that match the genre, or an empty array if no matches are found.
		/// </summary>
		/// <param name="genre">The genre to search for.</param>
		/// <returns>An array of movies that match the genre, or an empty array if no matches are found.</returns>
		public Movie[] FindByGenre(Genre genre)
		{
			List<Movie> filteredMovies = new List<Movie>();
			foreach (Movie movie in Movies)
			{
				if (movie.Genres.Contains(genre))
				{
					filteredMovies.Add(movie);
				}
			}
			return filteredMovies.ToArray();
		}

		/// <summary>
		/// Filters the movies in the movie list by a specified maximum playing time in minutes.
		/// Returns an array of movies that have a playing time less than or equal to the specified maximum,
		/// or an empty array if no matches are found.
		/// </summary>
		/// <param name="maxPlayingTimeInMinutes">The maximum playing time in minutes to filter by.</param>
		/// <returns>An array of movies that match the criteria, or an empty array if no matches are found.</returns>
		public Movie[] FilterMaxPlayingTime(int maxPlayingTimeInMinutes)
		{
			List<Movie> filteredMovies = new List<Movie>();
			foreach (Movie movie in Movies)
			{
				if (movie.PlayingTimeInMinutes <= maxPlayingTimeInMinutes)
				{
					filteredMovies.Add(movie);
				}
			}
			return filteredMovies.ToArray();
		}
	}
}
