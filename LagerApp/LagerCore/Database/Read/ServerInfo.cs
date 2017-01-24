using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerCore.Database.Read
{
    public static class ServerInfo
    {
        private static string _DB, _Server, _PW, _UID;

        public static void InitDBRead()
        {
            Logging.Write.SetLogFile(logDir: ".\\data\\logging", prefix: "Core_", writeText: false);
            try
            {
                if (!System.IO.Directory.Exists(@"Data"))
                {
                    System.IO.Directory.CreateDirectory(@"Data");

                    Logging.Write.Info("Created directory 'Data'");
                }

                if (!System.IO.File.Exists(@"Data\LagerData.dat"))
                {
                    using (StreamWriter sr = new StreamWriter(@"Data\LagerData.dat"))
                    {
                        string[] lst = System.IO.File.ReadAllLines(@"dbF.config");

                        foreach (var item in lst)
                        {
                            sr.WriteLine(LagerCore.Security.RNDJ.Crypto.Encrypt(item));
                        }
                    }

                    Logging.Write.Info("Created file 'LagerData.dat'");
                }
                else if (System.IO.File.Exists(@"Data\LagerData.dat"))
                {
                    string[] lst = System.IO.File.ReadAllLines(@"Data\LagerData.dat");
                    List<string> dec = new List<string>();

                    foreach (var item in lst)
                    {
                        dec.Add(LagerCore.Security.RNDJ.Crypto.Decrypt(item));
                    }

                    Server = dec.ElementAt<string>(1);
                    DB = dec.ElementAt<string>(3);
                    UID = dec.ElementAt<string>(5);
                    PW = dec.ElementAt<string>(7);

                    Logging.Write.Info("Read from LagerData file - Variables Ready for use");
                }
            }
            catch (Exception ex)
            {
                Logging.Write.Log(ex);
                Logging.Write.Error(ex.Message);
            }
        }

        public static string DB
        {
            get { return _DB; }
            set { _DB = value; }
        }

        public static string Server
        {
            get { return _Server; }
            set { _Server = value; }
        }

        public static string PW
        {
            get { return _PW; }
            set { _PW = value; }
        }

        public static string UID
        {
            get { return _UID; }
            set { _UID = value; }
        }
    }
}
