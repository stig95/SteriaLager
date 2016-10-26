using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerCore.Initiate.File
{
    public static class DBRead
    {
        private static string _DB, _Server, _PW, _UID;

        public static void InitDBRead()
        {
            Log.Write.SetLogFile(logDir: ".\\data\\Logging", prefix: "Core_", writeText: false);
            try
            {
                if (!System.IO.Directory.Exists(@"data"))
                {
                    System.IO.Directory.CreateDirectory(@"data");

                    Log.Write.Info("Created directory 'data'");
                }

                if (!System.IO.File.Exists(@"data\LagerApp.dat"))
                {
                    using (StreamWriter sr = new StreamWriter(@"data\LagerApp.dat"))
                    {
                        string[] lst = System.IO.File.ReadAllLines(@"dbF.config");

                        foreach (var item in lst)
                        {
                            sr.WriteLine(LagerCore.Security.Cipher.Encrypt(item));
                        }
                    }

                    Log.Write.Info("Created file 'LagerApp.dat'");
                }
                else if (System.IO.File.Exists(@"data\LagerApp.dat"))
                {
                    string[] lst = System.IO.File.ReadAllLines(@"data\LagerApp.dat");
                    List<string> dec = new List<string>();

                    foreach (var item in lst)
                    {
                        dec.Add(LagerCore.Security.Cipher.Decrypt(item));
                    }

                    Server = dec.ElementAt<string>(1);
                    DB = dec.ElementAt<string>(3);
                    UID = dec.ElementAt<string>(5);
                    PW = dec.ElementAt<string>(7);

                    Log.Write.Info("Read from LagerApp Config file - Variables Ready for use");
                }
            }
            catch (Exception ex)
            {
                Log.Write.Log(ex);
                Log.Write.Error(ex.Message);
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
