using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.User
{
    public class Create : DB.DBConnect
    {
        public void User(string username, string password)
        {
            string salt = Security.Encrypt.GenSalt();

            string hashPW = Security.Encrypt.Set(password, salt);

            Insert("INSERT INTO `Brukere`(`brukernavn`, `passord`, `sodium_chloride`, `kontor`) VALUES ('" + username + "','" + hashPW + "','" + salt + "',1)");
        }
    }
}
