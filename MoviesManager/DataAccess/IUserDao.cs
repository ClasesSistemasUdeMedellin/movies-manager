using MoviesManager.DataAccess.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.DataAccess
{
    public interface IUserDao
    {
        public void InsertUser(UserDto user);
        public UserDto GetUser(string userName);
    }
}
