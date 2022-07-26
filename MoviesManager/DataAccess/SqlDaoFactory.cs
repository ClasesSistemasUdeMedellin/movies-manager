﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoviesManager.DataAccess
{
    public class SqlDaoFactory : DaoFactory
    {

        private SqlConnection? _connection;

        public SqlConnection Connection
        {
            get 
            {
                if(_connection == null)
                    _connection = new SqlConnection(Settings.Default.ConnectionString);
                else if(_connection.State == System.Data.ConnectionState.Closed)
                    _connection.ConnectionString = Settings.Default.ConnectionString;

                return _connection; 
            }
        }

        public override IUserDao UserDao
        {
            get { return new SqlUserDao(Connection); }
        }

        public override IMovieDao MovieDao
        {
            get { return new SqlMovieDao(Connection); }
        }

        public SqlDaoFactory()
        {
        }
    }
}
