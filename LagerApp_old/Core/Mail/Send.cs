using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Mail
{
    public class Send
    {
        public static void PWToken(MailAddress reciever, int token)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sopstelager@gmail.com", "Sopra Steria LagerApp");
                mail.To.Add(reciever);
                mail.Subject = "Sopra Steria Lager - Passord Nøkkel";
                mail.Body = "For å nullstille ditt passord, oppgi denne nøkkelen: " + Convert.ToString(token);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sopstelager", "soprasterialager");
                SmtpServer.EnableSsl = true;

                SmtpServer.SendAsync(mail, null);

                MessageBox.Show("Sjekk registrert epost for nøkkel");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
