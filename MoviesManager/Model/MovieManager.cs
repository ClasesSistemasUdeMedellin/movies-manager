﻿using MoviesManager.DataAccess;
using MoviesManager.DataAccess.Dto;
using System;
using System.Data.SqlClient;

namespace MoviesManager.Model
{
	public class MovieManager
	{
		public List<Movie> Movies { get; set; }
		public List<User> Users { get; set;}

		private User? _user;

		public User? AuthenticatedUser
        {
			get { return _user; }
        }
		
		public MovieManager()
		{
			Movies = new List<Movie>();
            Users = new List<User>();
			_user = null;
        }

		public void RegisterUser(string username, string password, string name, string? email=null)
        {
			User user = new User(username, password, name, email);
			IUserDao userDao = DaoFactory.Factory.UserDao;
			try
			{
				userDao.InsertUser(user.UserDto);
			}
			catch (SqlException ex)
			{
				throw new DuplicatedUsernameException($"{username} already exists", ex);
			}
        }

		public void LoginUser(string username, string password)
        {
			IUserDao userDao = DaoFactory.Factory.UserDao;
			try
			{
				UserDto userDto = userDao.GetUser(username);
				User user = new User(userDto);
				user.Authenticate(password);
				_user = user;

			}
			catch(Exception ex) when (ex is UsernameNotFoundException ||
									  ex is IncorrectPasswordException)
            {
				throw new InvalidCredentialsException("Invalid credentials");
            }
        }
	}
}
