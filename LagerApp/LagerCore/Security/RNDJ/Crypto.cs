using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LagerCore.Security.RNDJ
{
    /*START RANDOM STRINGS (16Char)
      WCN2agkps379FGIs
      Ftubvfk4JPTCzEQJ
      BezK0Ps8CYxmnxFr
      T0fd1FNoCrtnXJp6
      zFC1HSQzvl0sT59o
      iLqs1x9bh2pniZWu
      IoBSRKl6VVimH1Ju
      AKfuttawSafCnzyc
      GbagAKJLM06ul0PU
      KLVEQbdC8eb8L87R

      START RANDOM STRINGS (32Char)
      cX42hzf1vLDuZzl7S6iE8HYLB8o7ahoa
      CZADqQ1YuDk5eGjlMryTZPNO5hEWaqYO
      pfrv4KbhIuPTyjk4Vx14O9c6awoy1PRy
      xELUcNRwT73eh9Cx5Iple3lkUyxniBDg
      ttiuKMzYveqiBpNFMkoGJhkNkINiINO0
      z4VwnMmvoOhCjUX3rHASFMD9lRQYo00R
      lgzpGkbfL9jQw0yHyODJzLf8FOs5hYXM
      YWO8BtlHIDvERVVlYaDNM3mkhxGcZhGb
      hIauMInIZL8I4rKoMORWGtCxXYXJLF4p
      gkSXCnxOMLP0CHF6tY97NLsw0D6osCmb

      END RANDOM STRINGS*/

    public static class Crypto
    {
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private static readonly string initVector = LagerCore.Properties.Resources.Vector;
        private static readonly string passPhrase = LagerCore.Properties.Resources.Phrase;
        // This constant is used to determine the keysize of the encryption algorithm
        private const int keysize = 256;
        //Encrypt
        public static string Encrypt(string plainText)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        //Decrypt
        public static string Decrypt(string cipherText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
