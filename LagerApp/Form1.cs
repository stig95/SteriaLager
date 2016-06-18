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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Core.DB.DBConnect DB = new Core.DB.DBConnect();


        private void integerTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.Insert("INSERT INTO VareTrondheim(strekkode, navn, antall) VALUES('" + kodeStrek.Text + "', '" + vareNavn.Text + "', '" + antBoks.Text + "')");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //DB.Insert("UPDATE VareTrondheim SET strekkode = '" + insertboxher + "', navn = '" insertboxher "', antall = '" insertboxher "')");
        }
    }
}
