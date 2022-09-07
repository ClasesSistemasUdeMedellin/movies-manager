using System;
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
                if(_connection == null )
                    _connection = new SqlConnection(Settings.Default.ConnectionString);

                return _connection; 
            }
        }

        public override SqlUserDao UserDao
        {
            get { return new SqlUserDao(Connection); }
        }

        public SqlDaoFactory()
        {
        }
    }
}
