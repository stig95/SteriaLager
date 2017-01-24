using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.User
{
    public static class Create
    {
        public static void User(string username, string password, string epost, int stilling, int kontor)
        {
            DB.DBConnect DB = new DB.DBConnect();

            try
            {
                string salt = Security.Encrypt.GenSalt();

                string hashPW = Security.Encrypt.Set(password, salt);

                int kont = setKontor(kontor);
                string still = setStilling(stilling);

                DB.Insert("INSERT INTO `Brukere`(`brukernavn`, `passord`, `sodium_chloride`, `email`, `kontor`, `stilling`) VALUES ('" + username + "','" + hashPW + "','" + salt + "','" + epost + "','" + kont + "','" + still + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunne ikke lage bruker : " + ex.Message);
            }
            finally
            {
                DB.Dispose();
            }
        }

        private static int setKontor(int kontor)
        {
            switch (kontor)
            {
                case 0:
                    return 1;

                case 1:
                    return 2;

                case 2:
                    return 3;
                default:
                    return 0;
            }
        }

        private static string setStilling(int stilling)
        {
            switch (stilling)
            {
                case 0:
                    return  "admin";

                case 1:
                    return "ansatt";
                default:
                    return "Undetermined";

            }

        }
    }
}

