namespace AGoodMovie
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create an empty list of movies to populate
			// List<Movie> movies = new List<Movie>();
			MovieList movieList = new MovieList();
			
			// Create movie objects and add them to the list
			Movie inception = new Movie();
			inception.Title = "Inception";
			inception.Genres = [Genre.Action, Genre.SciFi];
			inception.YearOfPublication = 2010;
			inception.PlayingTimeInMinutes = 148;
			inception.ShortDescription = "A thief enters dreams to plant an idea into a target's subconscious.";
			movieList.Add(inception);

			Movie theDarkKnight = new Movie();
			theDarkKnight.Title = "The Dark Knight";
			theDarkKnight.Genres = [Genre.Action, Genre.Drama];
			theDarkKnight.YearOfPublication = 2008;
			theDarkKnight.PlayingTimeInMinutes = 152;
			theDarkKnight.ShortDescription = "Batman faces Joker, a chaotic criminal threatening Gotham's stability.";
			movieList.Add(theDarkKnight);

			Movie superBad = new Movie();
			superBad.Title = "Superbad";
			superBad.Genres = [Genre.Comedy];
			superBad.YearOfPublication = 2007;
			superBad.PlayingTimeInMinutes = 113;
			superBad.ShortDescription = "Teen friends try to enjoy one last wild night before graduation.";
			movieList.Add(superBad);

			Movie theHangover = new Movie();
			theHangover.Title = "The Hangover";
			theHangover.Genres = [Genre.Comedy];
			theHangover.YearOfPublication = 2009;
			theHangover.PlayingTimeInMinutes = 100;
			theHangover.ShortDescription = "Friends retrace steps after a wild Las Vegas bachelor party.";
			movieList.Add(theHangover);

			Movie theForestGump = new Movie();
			theForestGump.Title = "The Forest Gump";
			theForestGump.Genres = [Genre.Drama, Genre.Romance];
			theForestGump.YearOfPublication = 1994;
			theForestGump.PlayingTimeInMinutes = 142;
			theForestGump.ShortDescription = "Kind-hearted man experiences historic events through extraordinary life.";
			movieList.Add(theForestGump);

			Movie theShawshankRedemption = new Movie();
			theShawshankRedemption.Title = "The Shawshank Redemption";
			theShawshankRedemption.Genres = [Genre.Drama];
			theShawshankRedemption.YearOfPublication = 1994;
			theShawshankRedemption.PlayingTimeInMinutes = 142;
			theShawshankRedemption.ShortDescription = "Banker forms friendships while serving life sentence in prison.";
			movieList.Add(theShawshankRedemption);

			Movie theConjuring = new Movie();
			theConjuring.Title = "The Conjuring";
			theConjuring.Genres = [Genre.Horror];
			theConjuring.YearOfPublication = 2013;
			theConjuring.PlayingTimeInMinutes = 112;
			theConjuring.ShortDescription = "Paranormal investigators help family terrorized by dark presence in their farmhouse.";
			movieList.Add(theConjuring);

			Movie aQuietPlace = new Movie();
			aQuietPlace.Title = "A Quiet Place";
			aQuietPlace.Genres = [Genre.Horror, Genre.SciFi];
			aQuietPlace.YearOfPublication = 2018;
			aQuietPlace.PlayingTimeInMinutes = 90;
			aQuietPlace.ShortDescription = "Family must remain silent to survive in world invaded by sound-sensitive creatures.";
			movieList.Add(aQuietPlace);

			Movie interstellar = new Movie();
			interstellar.Title = "Interstellar";
			interstellar.Genres = [Genre.SciFi, Genre.Drama];
			interstellar.YearOfPublication = 2014;
			interstellar.PlayingTimeInMinutes = 169;
			interstellar.ShortDescription = "Astronauts travel through wormhole to find new home for humanity as Earth deteriorates.";
			movieList.Add(interstellar);

			Movie theMatrix = new Movie();
			theMatrix.Title = "The Matrix";
			theMatrix.Genres = [Genre.Action, Genre.SciFi];
			theMatrix.YearOfPublication = 1999;
			theMatrix.PlayingTimeInMinutes = 136;
			theMatrix.ShortDescription = "Hacker discovers reality is a simulated world controlled by machines.";
			movieList.Add(theMatrix);

			Movie titanic = new Movie();
			titanic.Title = "Titanic";
			titanic.Genres = [Genre.Drama, Genre.Romance];
			titanic.YearOfPublication = 1997;
			titanic.PlayingTimeInMinutes = 195;
			titanic.ShortDescription = "Love story unfolds aboard ill-fated RMS Titanic during its maiden voyage.";
			movieList.Add(titanic);

			Movie theNotebook = new Movie();
			theNotebook.Title = "The Notebook";
			theNotebook.Genres = [Genre.Romance];
			theNotebook.YearOfPublication = 2004;
			theNotebook.PlayingTimeInMinutes = 123;
			theNotebook.ShortDescription = "A love story between two people separated by circumstances.";
			movieList.Add(theNotebook);

			// Display all movie names in the list
			Console.WriteLine("Movies in the list:");
			foreach (Movie movie in movieList.Movies)
			{
				Console.WriteLine(movie.Title);
			}

			// Search for specific movies by title
			Console.WriteLine("Enter a movie title to search for:");
			Movie? movieFound = null;
			while (movieFound == null)
			{
				Console.Write("Search: ");
				string? userSearchTitle = Console.ReadLine();
				if (movieList.FindByTitle(userSearchTitle!) != null)
				{
					movieFound = movieList.FindByTitle(userSearchTitle!);
					Console.WriteLine($"\nFound movie:\n{movieFound}");
				}
				else
				{
					Console.WriteLine("Movie not found. Please try again.");
				}
			}

			// Search for movies by genre
			Console.WriteLine($"\nEnter a genre to search for ({string.Join(", ", Enum.GetValues<Genre>())}):");
			Console.Write("Genre: ");
			string? userSearchGenre = Console.ReadLine();
		 	Movie[] moviesFoundByGenre = movieList.FindByGenre(Enum.Parse<Genre>(userSearchGenre!, true));

			if (moviesFoundByGenre.Length > 0)
			{
				Console.WriteLine($"\nMovies found in genre {userSearchGenre}:");
				foreach (Movie movie in moviesFoundByGenre)
				{
					Console.WriteLine($"{movie.Title} - Genres: {string.Join(", ", movie.Genres)}");
				}
			}
			else
			{
				Console.WriteLine($"No movies found in genre {userSearchGenre}.");
			}

			// Filter movies by maximum playing time
			Console.WriteLine("\nEnter a maximum playing time in minutes to filter movies:");
			Console.Write("Max playing time in minutes: ");
			int maxPlayingTime = int.Parse(Console.ReadLine()!);
			Movie[] filteredMovies = movieList.FilterMaxPlayingTime(maxPlayingTime);
			
			if (filteredMovies.Length > 0)
			{
				Console.WriteLine($"\nMovies with playing time less than or equal to {maxPlayingTime} minutes:");
				foreach (Movie movie in filteredMovies)
				{
					Console.WriteLine($"{movie.Title} - {movie.PlayingTimeInMinutes} minutes");
				}
			}
			else
			{
				Console.WriteLine($"No movies found with playing time less than or equal to {maxPlayingTime} minutes.");
			}
		}
	}
}
