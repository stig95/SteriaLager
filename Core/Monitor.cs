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
            toolStripLabel1.Text = "Main:" + v.Version;
            toolStripLabel2.Text = "Core: 0.0.0.29a5";
            toolStripLabel3.Text = "Launcher: 0.0.0.5a15";

            gridDataBoundGrid1.DataSource = db.Select("SHOW GLOBAL STATUS");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gridDataBoundGrid1.Model.ClearCells(GridRangeInfo.Table(), true);
            gridDataBoundGrid1.DataSource = db.Select("SHOW GLOBAL STATUS");
        }

        private void coreTick_Tick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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

            dt = db.Select("SELECT * FROM online");

            foreach (DataRow row in dt.Rows)
            {
                listBox1.Items.Clear();
                if (!listBox1.Items.Contains(row[1]))
                {
                    listBox1.Items.Add(row[1].ToString());
                }
            }
            
        }
    }
}
