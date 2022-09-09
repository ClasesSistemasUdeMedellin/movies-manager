using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManager.Model
{
    public class UsernameNotFoundException : Exception
    {
        public UsernameNotFoundException() { }
        public UsernameNotFoundException(string message)
            : base(message) { }
        public UsernameNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
