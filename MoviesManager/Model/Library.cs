using System;

namespace MoviesManager.Model
{
	public class Library
	{
		public List<Movie> Movies { get; set; }

		public List<Movie> PlanToWatch { get; set; }

		public List<Movie> Seen { get; set; }

		public Library()
		{
			Movies = new List<Movie>();
			PlanToWatch = new List<Movie>();
			Seen = new List<Movie>();
		}

		public void MarkPlanToWatch(Movie movie)
        {
			PlanToWatch.Add(movie);
        }

		public void MarkSeen(Movie movie)
        {
			Seen.Add(movie);
        }
	}
}
