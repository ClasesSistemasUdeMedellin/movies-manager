using System;

public class Movie
{
	public string Title { get;}
	public List<string> Categories { get; set; }
	public string Description { get; set; }
	public bool Status { get; set; } // I have doubts here too 😔

    public List<Review> Reviews { get; set; }

	public Movie(string title, List<string> categories, string description, int status)
	{
		Title = title;
		Categories = categories;
		Description = description;
		Status = status;
		Reviews = new List<Review>();
	}
}
