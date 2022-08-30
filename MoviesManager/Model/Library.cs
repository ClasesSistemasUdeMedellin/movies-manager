using System;

namespace MoviesManager.Model
{
	public class Library
	{
		public List<Movie> Movies { get; set; }

		public Library()
		{
			Movies = new List<Movie>();
		}
	}
}
