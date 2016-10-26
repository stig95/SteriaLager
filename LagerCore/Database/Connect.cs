using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Net.NetworkInformation;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace LagerCore.Database
{
    public class Connect
    {
        private MySqlConnection con = new MySqlConnection();
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

                Log.Write.Error(e.Message);
            }
            
        }

        //Initialize values
        private void Initialize()
        {
            server = LagerCore.Initiate.File.DBRead.Server;
            database = LagerCore.Initiate.File.DBRead.DB;
            uid = LagerCore.Initiate.File.DBRead.UID;
            password = LagerCore.Initiate.File.DBRead.PW;

            //server = "colargol.tihlde.org";
            //database = "stigkr";
            //uid = "stigkr";
            //password = "Test123";

            string connectionString;
            //connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            //database + ";" + "UID=" + uid + ";" + "Password=" + password + ";";

            connectionString = "server = " + server + ";" +
                               "database = " + database + ";" +
                               "uid = " + uid + ";" +
                               "password = " + password + ";";

            //con = new MySqlConnection(connectionString);

            con.ConnectionString = connectionString;

            Log.Write.Info("Initializes connection to database " + server);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                con.Open();
                Log.Write.Info("Opening connection to " + server);
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

                Log.Write.Log(ex);

                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                con.Close();
                Log.Write.Info("Closing connection to " + server);
                return true;
            }
            catch (MySqlException ex)
            {
                Log.Write.Log(ex);
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
                Log.Write.Log(ex);
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
                MessageBox.Show(ex.InnerException.ToString());
                MessageBox.Show(ex.Data.ToString());
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
            Log.Write.Info("Running insert query for " + server);
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

            Log.Write.Info("Finished insert query for " + server);
        }

        //Update statement
        public void Update(string query)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            Log.Write.Info("Running update query for " + server);
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

            Log.Write.Info("Finished update query for " + server);
        }

        //Delete statement
        public void Delete(string query)
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            Log.Write.Info("Running delete query for " + server);

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

            Log.Write.Info("Finished delete query for " + server);
        }

        //Select statement
        public DataTable Select(string query)
        {
            //string query = "SELECT * FROM tableinfo";
            Log.Write.Info("Running select query for " + server);
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

                Log.Write.Info("Finished select query for " + server);

                return dt;
            }
            else
            {
                dt.Columns.Add("Error", typeof(string));
                dt.Rows.Add("Unable to retrieve database info");

                Log.Write.Error("(Failed to retrieve) Finished insert query for " + server);
                return dt;
            }
        }

        //Count statement
        public int Count(string query)
        {
            //string query = "SELECT Count(*) FROM tableinfo";

            Log.Write.Info("Running count query for " + server);
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

                Log.Write.Info("Finished count query for " + server);

                return Count;
            }
            else
            {
                Log.Write.Error("(Error getting count) Finished insert query for " + server);
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                Log.Write.Info("Starting backup procedure for " + database + " @" + server);

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

                Log.Write.Info("Finished backup procedure for " + database + " @" + server);
            }
            catch (IOException ex)
            {
                Log.Write.Log(ex);
                Log.Write.Flush();
                MessageBox.Show("(See log) Error, unable to backup! " + ex.Message);
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                Log.Write.Warning("Running restore for " + database + " @" + server);

                Log.Write.Info("Retrieving newest SQL file from directory 'data\\database\\backup'");

                var directory = new DirectoryInfo(@"data\database\backup");

                var newest = directory.GetFiles()
                .OrderByDescending(f => f.LastWriteTime)
                .First();

                Log.Write.Info("Retrieved newest SQL file - " + newest.Name);

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

                Log.Write.Info("Finished restoring database from newest directoryfile - " + newest.FullName);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore! " + ex.Message);
            }
        }
    }
}
