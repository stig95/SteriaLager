using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace LagerCore.Database
{
    public class Connect
    {
        private MySqlConnection con;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Connect()
        {
            try
            {
                Initialize();
            }
            catch (Exception e)
            {

                Logging.Write.Error(e.Message);
            }
            
        }

        //Initialize values
        private void Initialize()
        {
            server = LagerCore.Database.Read.ServerInfo.Server;
            database = LagerCore.Database.Read.ServerInfo.DB;
            uid = LagerCore.Database.Read.ServerInfo.UID;
            password = LagerCore.Database.Read.ServerInfo.PW;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            con = new MySqlConnection(connectionString);

            Logging.Write.Info("Initializes connection to database " + server);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                con.Open();
                Logging.Write.Info("Opening connection to " + server);
                return true;
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

                Logging.Write.Log(ex);

                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                con.Close();
                Logging.Write.Info("Closing connection to " + server);
                return true;
            }
            catch (MySqlException ex)
            {
                Logging.Write.Log(ex);
                return false;
            }
        }

        //State statement

        public ConnectionState States()
        {
            try
            {
                con.Open();
                return con.State;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);

                return ConnectionState.Broken + ex.HResult;
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        //PING

        public int DBPing()
        {
            try
            {
                Ping pong = new Ping();
                PingReply reply = pong.Send(server);

                if (reply.Status == IPStatus.Success)
                {
                    return (int)reply.RoundtripTime;
                }
            }
            catch (Exception ex)
            {
                Logging.Write.Log(ex);
            }

            return -1;
        }

        //DB Version

        public string DBv()
        {
            try
            {
                con.Open();

                return con.ServerVersion;
            }
            catch (Exception ex)
            {
                return "Unable to retrieve DBv" + Environment.NewLine + ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        //Insert statement
        public void Insert(string query)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            Logging.Write.Info("Running insert query for " + server);
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, con);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

            Logging.Write.Info("Finished insert query for " + server);
        }

        //Update statement
        public void Update(string query)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            Logging.Write.Info("Running update query for " + server);
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = con;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

            Logging.Write.Info("Finished update query for " + server);
        }

        //Delete statement
        public void Delete(string query)
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            Logging.Write.Info("Running delete query for " + server);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

            Logging.Write.Info("Finished delete query for " + server);
        }

        //Select statement
        public DataTable Select(string query)
        {
            //string query = "SELECT * FROM tableinfo";
            Logging.Write.Info("Running select query for " + server);
            //Create a datatable to store the result
            DataTable dt = new DataTable();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con);
                //Create a data reader and Execute the command
                //MySqlDataReader dataReader = cmd.ExecuteReader();
                MySqlDataAdapter da = new MySqlDataAdapter();

                //Read the data and store them in the list
                //while (dataReader.Read())
                //{
                //    list[0].Add(dataReader["id"] + "");
                //    list[1].Add(dataReader["name"] + "");
                //    list[2].Add(dataReader["age"] + "");
                //}

                da.SelectCommand = cmd;
                da.Fill(dt);

                //close Data Reader
                //dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed

                Logging.Write.Info("Finished select query for " + server);

                return dt;
            }
            else
            {
                dt.Columns.Add("Error", typeof(string));
                dt.Rows.Add("Unable to retrieve database info");

                Logging.Write.Error("(Failed to retrieve) Finished insert query for " + server);
                return dt;
            }
        }

        //Count statement
        public int Count(string query)
        {
            //string query = "SELECT Count(*) FROM tableinfo";

            Logging.Write.Info("Running count query for " + server);
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, con);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                Logging.Write.Info("Finished count query for " + server);

                return Count;
            }
            else
            {
                Logging.Write.Error("(Error getting count) Finished insert query for " + server);
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                Logging.Write.Info("Starting backup procedure for " + database + " @" + server);

                if (!System.IO.Directory.Exists(@"data\database\backup\"))
                {
                    System.IO.Directory.CreateDirectory(@"data\database\backup\");
                }

                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = @"data\database\backup\SQL" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        OpenConnection();
                        mb.ExportToFile(path);
                        CloseConnection();
                    }
                }

                Logging.Write.Info("Finished backup procedure for " + database + " @" + server);
            }
            catch (IOException ex)
            {
                Logging.Write.Log(ex);
                Logging.Write.Flush();
                MessageBox.Show("(See log) Error, unable to backup! " + ex.Message);
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                Logging.Write.Warning("Running restore for " + database + " @" + server);

                Logging.Write.Info("Retrieving newest SQL file from directory 'data\\database\\backup'");

                var directory = new DirectoryInfo(@"data\database\backup");

                var newest = directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .First();

                Logging.Write.Info("Retrieved newest SQL file - " + newest.Name);

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        OpenConnection();
                        mb.ImportFromFile(newest.FullName);
                        CloseConnection();
                    }
                }

                Logging.Write.Info("Finished restoring database from newest directoryfile - " + newest.FullName);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore! " + ex.Message);
            }
        }
    }
}
