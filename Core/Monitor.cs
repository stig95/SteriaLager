using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Monitor_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Main:" + v.Version;
            toolStripLabel2.Text = "Core: 0.0.0.29a5";
            toolStripLabel3.Text = "Launcher: 0.0.0.5a15";

            gridDataBoundGrid1.DataSource = db.Select("SHOW GLOBAL STATUS");
        }
    }
}
