using System;

namespace MoviesManager.Model
{
	public class MovieManager
	{
		public List<Movie> Movies { get; set; }
		public List<User> Users { get; set;}

		public MovieManager()
		{
			Movies = new List<Movie>();
            Users = new List<User>();
        }
	}
}
