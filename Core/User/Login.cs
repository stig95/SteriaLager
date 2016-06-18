using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.User
{
    public class Login
    {
        DB.DBConnect DB = new Core.DB.DBConnect();

        public bool Check(string username, string password)
        {
            DataTable dt = new DataTable();

            dt = DB.Select("SELECT sodium_chloride FROM Brukere WHERE brukernavn ='" + username + "'");

            string hashPW = Security.Encrypt.Set(password, dt.Rows[0].Field<string>(0).ToString());

            dt.Clear();

            dt = DB.Select("SELECT brukernavn, passord, stilling FROM Brukere WHERE brukernavn='" + username + "' AND passord='" + hashPW + "'");

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
