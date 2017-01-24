using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagerMain.Login
{
    public partial class frmConsole : Form
    {
        public frmConsole()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            LagerCore.Database.Read.ServerInfo.InitDBRead();
            Thread.Sleep(5000);
            foreach (var item in System.IO.File.ReadAllLines(@"data\LagerData.dat"))
            {
                richTextBox1.Text += LagerCore.Security.RNDJ.Crypto.Decrypt(item) + Environment.NewLine;
            }

            LagerCore.Database.Connect dbc = new LagerCore.Database.Connect();

            MessageBox.Show(Convert.ToString(dbc.Count("SELECT COUNT(*) FROM VareStavanger")));
        }
    }
}
