using MoviesManager.DataAccess.Dto;
using MoviesManager.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.DataAccess
{
    public class SqlUserDao : IUserDao
    {
        private SqlConnection _connection;

        public SqlUserDao(SqlConnection connection)
        {
            _connection = connection;
        }

        public UserDto GetUser(string username)
        {
            using (_connection)
            {
                _connection.Open();
                using (SqlCommand cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT Username, Password, Name, Email, UserGuid FROM [Users] WHERE Username = @USERNAME";
                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserDto userDto = new UserDto();
                            userDto.Username = Convert.ToString(reader["Username"]);
                            userDto.Password = Convert.ToString(reader["Password"]);
                            userDto.Name = Convert.ToString(reader["Name"]);
                            userDto.Email = Convert.ToString(reader["Email"]);
                            userDto.UserGuid = Convert.ToString(reader["UserGuid"]);
                            return userDto;
                        }
                        else
                        {
                            throw new UsernameNotFoundException($"The username {username} is not registered");
                        }
                    }
                }
            }
        }

        public void InsertUser(UserDto user)
        {
            using (_connection)
            {
                _connection.Open();
                using (SqlCommand cmd = _connection.CreateCommand())
                {
                    string values = "@NAME, @EMAIL, @USERNAME', @PASSWORD, @USERGUID";
                    cmd.CommandText = $"INSERT INTO [Users](Name, Email, Username, Password, UserGuid) VALUES ({values})";
                    cmd.Parameters.AddWithValue("@NAME", user.Name);
                    cmd.Parameters.AddWithValue("@EMAIL", user.Email);
                    cmd.Parameters.AddWithValue("@USERNAME", user.Username);
                    cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
                    cmd.Parameters.AddWithValue("@USERGUID", user.UserGuid);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
