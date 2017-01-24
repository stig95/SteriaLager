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

        public int Check(string username, string password)
        {
            DataTable dt = new DataTable();

            try
            {
                

                dt = DB.Select("SELECT sodium_chloride FROM Brukere WHERE brukernavn ='" + username + "'");

                string hashPW = Security.Encrypt.Set(password, dt.Rows[0].Field<string>(0).ToString());

                dt.Clear();

                dt = DB.Select("SELECT brukernavn, passord, stilling FROM Brukere WHERE brukernavn='" + username + "' AND passord='" + hashPW + "'");

                DB.Update("UPDATE Brukere Set ResetToken=0 WHERE brukernavn='" + username + "'");

                DB.Dispose();

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DB.Dispose();
                dt.Dispose();
            }
            

            
        }
    }
}
