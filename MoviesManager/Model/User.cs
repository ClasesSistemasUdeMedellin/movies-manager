using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.Model
{
    public class User
    {
        public string Username { get; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; }

        private bool _validCredentials = false;

        public Library Library { get; set; }

        public bool IsAuthenticated { 
            get
            {
                return _validCredentials;
            }
        }

        public User(string username, string name, string email, string password)
        {
            Username = username;
            Name = name;
            Email = email;
            Password = password;
            Library = new Library();
            // This is a test comment
        }

        public void Authenticate()
        {
            // TODO: Validate with database data
            if (_validCredentials)
            {
                throw new Exception("El usuario ya está autenticado");
            }
            else
            {
                if (Username == Resources.User && Password == Resources.Password)
                    _validCredentials = true;
                else
                    throw new Exception("Nombre de usuario o contraseña incorrectos");
            }
        }
    }
}
