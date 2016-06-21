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
        DB.DBConnect DB = new DB.DBConnect();
        Set SetUsr = new Set();

        public int Check(string username, string password)
        {
            DataTable dt = new DataTable();

            dt = DB.Select("SELECT sodium_chloride FROM Brukere WHERE brukernavn ='" + username + "'");

            string hashPW = Security.Encrypt.Set(password, dt.Rows[0].Field<string>(0).ToString());

            dt.Clear();

            dt = DB.Select("SELECT brukernavn, passord, stilling FROM Brukere WHERE brukernavn='" + username + "' AND passord='" + hashPW + "'");

            SetUsr.User = username;

            DB.Update("UPDATE Brukere Set ResetToken=0 WHERE brukernavn='" + username + "'");

            if (dt.Rows.Count > 0 && dt.Rows[0].Field<string>(2) == "admin")
            {
                return 1;
            }
            else if (dt.Rows.Count > 0 && dt.Rows[0].Field<string>(2) == "ansatt")
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
