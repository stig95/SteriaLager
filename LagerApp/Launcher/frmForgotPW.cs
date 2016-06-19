#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    public partial class frmForgotPW : Syncfusion.Windows.Forms.MetroForm
    {
        public frmForgotPW()
        {
            InitializeComponent();
            ShowIcon = false;

            textBoxExt3.Enabled = false;
            textBoxExt4.Enabled = false;
            textBoxExt5.Enabled = false;
        }

        Core.DB.DBConnect DB = new Core.DB.DBConnect();

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            Core.User.Recover rec = new Core.User.Recover();
            if (rec.GetToken(textBoxExt1.Text, textBoxExt2.Text))
            {
                textBoxExt3.Enabled = true;
                textBoxExt4.Enabled = true;
                textBoxExt5.Enabled = true;

                buttonAdv1.Text = "Endre Passord";
            }
            else
            {
                MessageBox.Show("Ingen registrerte med oppnevnt brukernavn/epost","Feil brukernavn/epost");
            }

            if (buttonAdv1.Text == "Endre Passord")
            {
                DataTable dt = new DataTable();

                dt = DB.Select("SELECT ResetToken FROM Brukere WHERE brukernavn='" + textBoxExt1.Text + "' AND email='" + textBoxExt2.Text + "'");
                if (textBoxExt4.Text == textBoxExt5.Text && textBoxExt3.Text == dt.Rows[0].Field<int>(0).ToString())
                {
                    string salt = Core.Security.Encrypt.GenSalt();

                    string hashPW = Core.Security.Encrypt.Set(textBoxExt5.Text, salt);

                    DB.Update("UPDATE `Brukere` SET `passord`='" + hashPW + "',`sodium_chloride`='" + salt + "' WHERE ResetToken='"+ textBoxExt3.Text + "' AND email='" + textBoxExt2.Text + "'");

                    MessageBox.Show("Passord endret for bruker " + textBoxExt1.Text);
                }
                else
                {
                    MessageBox.Show("Passordene stemmer ikke og/eller nøkkelen er feil");
                }
                
            }
        }
    }
}
