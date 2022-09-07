using MoviesManager.DataAccess;
using MoviesManager.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.Model
{
    public class User
    {
        private UserDto _userDto;
        
        private bool _validCredentials = false;

        public Library Library { get; set; }

        public bool IsAuthenticated { 
            get
            {
                return _validCredentials;
            }
        }

        public UserDto UserDto
        {
            get
            {
                return _userDto;
            }
        }

        public User(string username, string password, string name, string? email=null)
        {
            _userDto = new UserDto();
            _userDto.UserGuid = Guid.NewGuid().ToString();
            _userDto.Username = username;
            _userDto.Name = name;
            _userDto.Email = email;
            _userDto.Password = Encryptor.SHA1Hash(password + _userDto.UserGuid);
            Library = new Library();
        }

        public User(UserDto dto)
        {
            _userDto = dto;
            Library = new Library();
        }

        public void Authenticate(string password)
        {
            if (_validCredentials)
            {
                throw new Exception("El usuario ya está autenticado");
            }
            else
            {
                string hashPassword = Encryptor.SHA1Hash(password + _userDto.UserGuid);
                StringComparer comparer = StringComparer.Ordinal;
                if(comparer.Compare(hashPassword, _userDto.Password) == 0)
                {
                    _validCredentials = true;
                }
                else
                {
                    throw new IncorrectPasswordException("Wrong password");
                }
            }
        }
    }
}
