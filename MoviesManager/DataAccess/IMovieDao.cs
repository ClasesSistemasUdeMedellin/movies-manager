using MoviesManager.DataAccess.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.DataAccess
{
    public interface IMovieDao
    {
        public int InsertMovie(MovieDto movie);
        public MovieDto GetMovieById(int id);

        public List<MovieDto> FilterByTitle(string title);

        public List<MovieDto> GetAll();

        public List<CategoryDto> GetAllCategories();

        public List<MovieStatusDto> GetAllStatuses();
    }
}
