using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Win32;
using System.Xml;

namespace Core
{
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
        }

        Version.Controller v = new Version.Controller();
        DB.DBConnect db = new DB.DBConnect();
        Process current = Process.GetCurrentProcess();
        CPU.get CPU = new CPU.get();

        private void Monitor_Load(object sender, EventArgs e)
        {
            toolStripLabel4.Text = "Main:" + v.Version.ToString();
            toolStripLabel5.Text = "Core: 0.0.0.29a5";
            toolStripLabel6.Text = "Launcher: 0.0.0.5a15";

            gridDataBoundGrid3.DataSource = db.Select("SHOW GLOBAL STATUS");

            label12.Text = Core.Network.ExternalIP.Get();
            label13.Text = Core.Network.LocalIP.Get();
            label14.Text = Core.Network.MAC.Get();
            label15.Text = Core.Network.User.Get();
        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    gridDataBoundGrid3.Model.ClearCells(GridRangeInfo.Table(), true);
        //    gridDataBoundGrid3.DataSource = db.Select("SHOW GLOBAL STATUS");
        //}



        private void tick_Tick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                
                dt.Clear();
                double mm = GC.GetTotalMemory(false) / 1024 / 1024;

                label1.Text = Convert.ToString(mm) + "MB Allocated GC";

                double nn = current.PrivateMemorySize64 / 1024 / 1024;

                label2.Text = Convert.ToString(nn) + "MB In Use";

                label3.Text = "Total CPU Time: " + Convert.ToString(current.TotalProcessorTime);

                label4.Text = "CPU Usage: " + Convert.ToString(CPU.GetUsage()) + "%";

                label5.Text = "Ping: " + Convert.ToString(db.DBPing()) + "ms";

                label6.Text = "Server Version: " + db.DBv();

                label7.Text = "Server State: " + db.States();

                gridDataBoundGrid4.DataSource = db.Select("SELECT * FROM online");
            }
            catch (Exception)
            {

                //DO ERROR
            }
            finally
            {
                dt.Dispose();
            }
            
        }

        
    }
}
