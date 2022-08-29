using System;

public class Review
{
	public double Score { get; set; }
	public string Comment { get; set; }
	public Review(double score, string comment)
	{
		Score = score;
		Comment = comment;
	}
}
