using MoviesManager.DataAccess;
using MoviesManager.DataAccess.Dto;
using System;

namespace MoviesManager.Model
{

	public class Movie
	{
		private MovieDto _movieDto;

		public MovieDto MovieDto
        {
			get { return _movieDto; }
        }

		public Movie(string title, List<CategoryDto> categories, string description, MovieStatusDto status, string Username)
		{
			_movieDto = new MovieDto();
			_movieDto.Title = title;
			_movieDto.Categories = categories;
			_movieDto.Description = description;
			_movieDto.Status = status;
			_movieDto.Username = Username;
		}

		public Movie(MovieDto dto)
        {
			_movieDto = dto;
        }

		public static List<CategoryDto> Categories
        {
			get
            {
				IMovieDao movieDao = DaoFactory.Factory.MovieDao;
				return movieDao.GetAllCategories();
            }
        }

		public static List<MovieStatusDto> Statuses
        {
            get
            {
				IMovieDao movieDao = DaoFactory.Factory.MovieDao;
				return movieDao.GetAllStatuses();
            }
        }
	}
}
