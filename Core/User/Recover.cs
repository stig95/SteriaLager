using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Net.Mail;

namespace Core.User
{
    public class Recover : DB.DBConnect
    {
        DataTable dt = new DataTable();

        public bool GetToken(string username, string email)
        {
            
            try
            {
                dt = Select("SELECT * FROM Brukere WHERE brukernavn='" + username + "' AND email='" + email + "'");
                int token;
                if (dt.Rows.Count > 0)
                {
                    using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                    {
                        // Buffer storage.
                        byte[] data = new byte[2];

                        
                        
                        // Fill buffer.
                        rng.GetBytes(data);

                        // Convert to int 32.
                        int value = BitConverter.ToInt16(data, 0);

                        value = Math.Abs(value);
                        token = value;

                        Insert("UPDATE `Brukere` SET `ResetToken`='" + value + "' WHERE brukernavn='" + username + "' AND email='" + email + "'");

                        
                    }

                    Mail.Send.PWToken(new MailAddress(email), token);

                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
    }
}
