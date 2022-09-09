using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.Model
{
    public class DuplicatedUsernameException : Exception
    {
        public DuplicatedUsernameException() { }
        public DuplicatedUsernameException(string message) 
            : base(message) { }
        public DuplicatedUsernameException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
