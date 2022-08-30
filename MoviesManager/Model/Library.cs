using System;

namespace MoviesManager.Model
{
	public class Library
	{
		public List<Movie> Movies { get; set; }
		// test commentary to check modifications

		public Library()
		{
			Movies = new List<Movie>();
		}
	}
}
