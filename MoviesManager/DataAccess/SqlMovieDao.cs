using MoviesManager.DataAccess.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.DataAccess
{
    public class SqlMovieDao : IMovieDao
    {
        private SqlConnection _connection;

        public SqlMovieDao(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<MovieDto> FilterByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<MovieDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> GetAllCategories()
        {
            List<CategoryDto> result = new List<CategoryDto>();
            using(_connection)
            {
                _connection.Open();
                using(SqlCommand cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [Categories]";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            CategoryDto category = new CategoryDto();
                            category.Id = Convert.ToInt32(reader["Id"]);
                            category.Name = Convert.ToString(reader["Name"]);
                            result.Add(category);
                        }
                    }
                }
            }
            return result;
        }

        public List<MovieStatusDto> GetAllStatuses()
        {
            List<MovieStatusDto> result = new List<MovieStatusDto>();
            using (_connection)
            {
                _connection.Open();
                using (SqlCommand cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [MovieStatus]";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MovieStatusDto status = new MovieStatusDto();
                            status.Id = Convert.ToInt32(reader["Id"]);
                            status.Name = Convert.ToString(reader["Name"]);
                            result.Add(status);
                        }
                    }
                }
            }
            return result;
        }

        public MovieDto GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertMovie(MovieDto movie)
        {
            using(_connection)
            {
                _connection.Open();
                using(SqlCommand cmd = _connection.CreateCommand())
                {
                    string values = $"'{movie.Title}', '{movie.Description}', {movie.Status.Id}";
                    cmd.CommandText = $"INSERT INTO [Movies](Title, Description, Status) OUTPUT INSERTED.ID VALUES({values})";
                    int movideId = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach(CategoryDto category in movie.Categories)
                    {
                        cmd.CommandText = $"INSERT INTO [MoviesByCategory](MovieId, CategoryId) VALUES({movideId}, {category.Id})";
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = $"INSERT INTO [UserMovies](Username, MovieId) VALUES ('{movie.Username}', {movideId})";
                    cmd.ExecuteNonQuery();

                    return movideId;
                }
            }
        }
    }
}
