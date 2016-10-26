using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LagerCore.Security
{
    public class SHA
    {
        public static string Set(string plainText, string salt)
        {
            byte[] result;

            byte[] hash = System.Text.Encoding.UTF8.GetBytes(string.Concat(plainText, salt));

            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(hash);

            return Convert.ToBase64String(result);
        }

        public static string GenSalt()
        {
            var salt = new byte[32];

            using (var rnd = new RNGCryptoServiceProvider())
            {
                rnd.GetNonZeroBytes(salt);
            }

            return Convert.ToBase64String(salt);
        }
    }
}
