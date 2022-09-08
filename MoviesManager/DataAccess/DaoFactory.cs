using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.DataAccess
{
    public abstract class DaoFactory
    {
        private static DaoFactory? _factory;
        public static DaoFactory? Factory
        {
            get
            {
                if(_factory == null)
                {
                    string factoryClass = Settings.Default.DaoFactoryClass;
                    var objectType = Type.GetType(factoryClass);
                    _factory = Activator.CreateInstance(objectType) as DaoFactory;
                }
                return _factory;
            }
        }

        public abstract IUserDao UserDao { get; }
        public abstract IMovieDao MovieDao { get; }
    }

   
}
