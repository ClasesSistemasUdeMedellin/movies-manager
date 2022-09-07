using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MoviesManager.Util
{
    public class Encryptor
    {
        public static string SHA1Hash(string text)
        {
            SHA1 sha1 = SHA1.Create();

            // Compute hash from the bytes of text
            byte[] hash = sha1.ComputeHash(ASCIIEncoding.UTF8.GetBytes(text));

            
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                strBuilder.Append(hash[i].ToString("X2"));
            }

            return strBuilder.ToString();
        }
    }
}
