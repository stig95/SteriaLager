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
using Core;
using MySql.Data.MySqlClient;

namespace LagerApp
{
    public partial class frmLagerApp : Syncfusion.Windows.Forms.MetroForm
    {
        Core.DB.DBConnect DB = new Core.DB.DBConnect();

        public frmLagerApp()
        {
            InitializeComponent();
            ShowIcon = false;
            Text = null;

            tabPageAdv1.Image = Core.Properties.Resources.sslogotransparent;
            CaptionImages.FindByName("SSLogoTop").Image = Core.Properties.Resources.sslogotransparent;

        }
        /// <summary>
        /// rip in potatoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vareAdd_Click(object sender, EventArgs e)
        {
            string lol = kodeStrek.Text;
            lol.Replace(" ", "");
            DB.Insert("INSERT INTO VareTrondheim(strekkode, navn, antall) VALUES('" + lol + "', '" + vareNavn.Text + "', '" + antBoks.Text + "')");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB.Insert("DELETE FROM VareTrondheim WHERE navn = '" + vareSlett.SelectedItem + "'");

        }

        private void frmLagerApp_Load(object sender, EventArgs e)
        {
            try
            {
               
                DataTable dt = new DataTable();

                dt = DB.Select("SELECT navn FROM VareTrondheim"); 

                foreach (DataRow row in dt.Rows)
                {
                    vareSlett.Items.Add(row.Field<string>(0));
                    vareEndre.Items.Add(row.Field<string>(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("is fubar yo" + ex.Message);
            }

        }

        

        





        private void btnVareSlett_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            dt3 = DB.Select("SELECT * FROM VareTrondheim WHERE navn =" + vareEndre.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
