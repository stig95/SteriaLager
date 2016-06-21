using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace LagerApp
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        Core.DB.DBConnect DB = new Core.DB.DBConnect();


        private void integerTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //DB.Insert("UPDATE VareTrondheim SET strekkode = '" + insertboxher + "', navn = '" insertboxher "', antall = '" insertboxher "')");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLagerApp frm = new frmLagerApp();
            frm.Show();
        }

        private void vareNavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void antBoks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
