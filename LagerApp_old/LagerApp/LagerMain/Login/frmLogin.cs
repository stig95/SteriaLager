#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using MySql.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LagerMain.Login
{
    public partial class frmLogin : Syncfusion.Windows.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();

            foreach (Control item in mainContainer.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }

            LagerCore.Initiate.StartUp.Run();

            txtPassord.PasswordChar = '\u25CF';
        }

        
        LagerCore.Database.Connect DBCon = new LagerCore.Database.Connect();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    MessageBox.Show("" + DBCon.States());
            //    MessageBox.Show(
            //                    LagerCore.Initiate.File.DBRead.Server + "-\n" +
            //                    LagerCore.Initiate.File.DBRead.DB + "-\n" +
            //                    LagerCore.Initiate.File.DBRead.UID + "-\n" +
            //                    LagerCore.Initiate.File.DBRead.PW + "-\n" + Convert.ToString(DBCon.DBPing()));

            //    MessageBox.Show(DBCon.DBv());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

            richTextBox1.Text = LagerCore.Initiate.File.DBRead.Server + Environment.NewLine +
                                LagerCore.Initiate.File.DBRead.DB + Environment.NewLine +
                                LagerCore.Initiate.File.DBRead.UID + Environment.NewLine +
                                LagerCore.Initiate.File.DBRead.PW + Environment.NewLine;


            //richTextBox1.Text += Environment.NewLine + DBCon.DBPing() + Environment.NewLine + DBCon.DBv();

            DataTable dt = DBCon.Select("SELECT * FROM VControll");

            foreach (DataRow item in dt.Rows)
            {
                foreach (DataColumn dtc in dt.Columns)
                {
                    richTextBox1.Text += item[dtc];
                }
            }

        }
    }
}
