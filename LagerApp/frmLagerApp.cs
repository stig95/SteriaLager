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

namespace LagerApp
{
    public partial class frmLagerApp : Syncfusion.Windows.Forms.MetroForm
    {
        Core.DB.DBConnect DB = new Core.DB.DBConnect();
        Core.User.Set User = new Core.User.Set();

        public frmLagerApp()
        {
            InitializeComponent();
            ShowIcon = false;
            Text = "Sopra Steria Lager | Innlogget som " + User.User;

            CaptionBarHeight = 48;

            tabOverview.Image = Core.Properties.Resources.overview;
            tabStorage.Image = Core.Properties.Resources.storage;
            tabAddRemove.Image = Core.Properties.Resources.addVare;
            tabChange.Image = Core.Properties.Resources.editVare;
            tabUser.Image = Core.Properties.Resources.userOverview;

        }

        /// <summary>
        /// rip in potatoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVareAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(intKodeStrek.Text);

                //DB.Insert("INSERT INTO VareTrondheim(strekkode, navn, antall) VALUES('" + lol + "', '" + txtVareNavn.Text + "', '" + antBoks.Text + "')");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Keke" + ex.Message);

            }


        }

        private void frmLagerApp_Load(object sender, EventArgs e)
        {

            MessageBox.Show(User.User);

            try
            {

                //DataTable dt = new DataTable();

                //dt = DB.Select("SELECT navn FROM VareTrondheim");

                //foreach (DataRow row in dt.Rows)
                //{
                //    vareSlett.Items.Add(row.Field<string>(0));
                //    vareEndre.Items.Add(row.Field<string>(0));
                //}

                //dt.Clear();

                int lager = DB.Count("SELECT COUNT(vareID) FROM VareTrondheim");

                int tot = lager;

                lblTrdLager.Text = "Trondheim: " + lager + " enheter";

                lager = DB.Count("SELECT COUNT(vareID) FROM VareStavanger");

                tot += lager;

                lblStavLager.Text = "Stavanger: " + lager + " enheter";

                lager = DB.Count("SELECT COUNT(vareID) FROM VareOslo");

                tot += lager;

                lblOslLager.Text = "Oslo: " + lager + " enheter";

                tsLblTotAntVare.Text = "Totalt registrerte enheter: " + tot;
            }
            catch (Exception ex)
            {
                MessageBox.Show("is fubar yo : " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DB.Insert("UPDATE VareTrondheim SET Strekkode = '" + endreStrek.Text + "', navn = '" + endreNavn.Text + "', antall = '" + endreAnt.Text + "'");
        }

        private void cmbLager_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            switch (cmbLager.SelectedIndex)
            {
                case 0:
                    
                    dt = DB.Select("SELECT navn FROM VareTrondheim");
                    break;

                case 1:

                    dt = DB.Select("SELECT navn FROM VareOslo");
                    break;

                case 2:

                    dt = DB.Select("SELECT navn FROM VareStavanger");

                    break;
            }

            cmbVare.Items.Clear();

            if (dt.Rows.Count > 0)
            {
            foreach (DataRow dtRow in dt.Rows)
                {
                    cmbVare.Items.Add(dtRow.Field<string>(0));
                }
            }
            else
            {
                cmbVare.Items.Add("Ingen varer å vise");
            }

            dt.Dispose();
            
        }

        private void cmbVare_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbVare.SelectedItem.ToString());

            try
            {
                DataTable dt = new DataTable();

                switch (cmbLager.SelectedIndex)
                {
                    case 0:

                        dt = DB.Select("SELECT * FROM VareTrondheim WHERE navn='" + cmbVare.SelectedItem.ToString() + "'");
                        break;

                    case 1:

                        dt = DB.Select("SELECT * FROM VareOslo WHERE navn='" + cmbVare.SelectedItem.ToString() + "'");
                        break;

                    case 2:

                        dt = DB.Select("SELECT * FROM VareStavanger WHERE navn='" + cmbVare.SelectedItem.ToString() + "'");

                        break;
                }

                lstInfoDelete.Items.Add("Du har valgt følgende vare: ");
                lstInfoDelete.Items.Add("Navn: " + dt.Rows[0].Field<string>(2));
                lstInfoDelete.Items.Add("Strekkode: " + dt.Rows[0].Field<int>(1));
                lstInfoDelete.Items.Add("Antall: " + dt.Rows[0].Field<int>(3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void btnVareAdd_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(intKodeStrek.Text);
            MessageBox.Show(intAntall.IntegerValue.ToString());
        }
    }
}
