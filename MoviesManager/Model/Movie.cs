using System;

namespace MoviesManager.Model
{
	public enum MovieStatus
	{
		COMING_SOON,
		ON_BILLBOARD
	}

	public class Movie
	{
		public string Title { get; }
		public List<string> Categories { get; set; }
		public string Description { get; set; }
		public MovieStatus Status { get; set; }

		public List<Review> Reviews { get; set; }

		public Movie(string title, List<string> categories, string description, MovieStatus status)
		{
			Title = title;
			Categories = categories;
			Description = description;
			Status = status;
			Reviews = new List<Review>();
		}
	}
}
