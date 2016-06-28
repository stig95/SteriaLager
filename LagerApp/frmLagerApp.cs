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
            Text = "Sopra Steria Lager | Innlogget som " + User._user;

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
        private void frmLagerApp_Load(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show(ex.Message, "Is fubar yo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbLager_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
               
                cmbVare.Items.Clear();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                dt.Dispose();
            }
            

            
            
        }

        private void cmbVare_SelectedValueChanged(object sender, EventArgs e)
        {

            if (!((string)cmbVare.SelectedItem == "Ingen varer å vise"))
            {
                DataTable dt = new DataTable();

                try
                {
                    
                    dt.Clear();

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
                    lstInfoDelete.Items.Clear();
                    lstInfoDelete.Items.Add("Du har valgt følgende vare: ");
                    lstInfoDelete.Items.Add("Navn: " + dt.Rows[0].Field<string>(2));
                    lstInfoDelete.Items.Add("Strekkode: " + dt.Rows[0].Field<int>(1));
                    lstInfoDelete.Items.Add("Antall: " + dt.Rows[0].Field<int>(3));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dt.Dispose();
                }
            }

            
            
        }

        private void btnVareAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVareNavn.Text.Length > 3 && !(IsNumeric(txtVareNavn.Text)))
                {
                    if (intKodeStrek.IntegerValue.ToString().Length == 13 || intKodeStrek.IntegerValue.ToString().Length == 8)
                    {

                    }else
                    {
                        MessageBox.Show("EAN koden må være 13 eller 8 siffre");
                    }
                }else
                {
                    MessageBox.Show("Varen må ha ett gyldig navn (NonNumeric)");
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private bool IsNumeric(string input)
        {
            int output;
            return int.TryParse(input, out output);
        }

        private void textBoxExt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                MessageBox.Show("It works");
                //If true, søk etter EAN | Hvis ikke søk på navn
                if (IsNumeric(textBoxExt1.Text))
                {
                    try
                    {
                        switch (cmbSokLager.SelectedIndex)
                        {
                            case 0:

                                dt = DB.Select("SELECT * FROM VareTrondheim WHERE Strekkode LIKE '%" + textBoxExt1.Text + "%'");
                                break;

                            case 1:

                                dt = DB.Select("SELECT * FROM VareOslo WHERE Strekkode LIKE '%" + textBoxExt1.Text + "%'");
                                break;

                            case 2:

                                dt = DB.Select("SELECT * FROM VareStavanger WHERE Strekkode LIKE '%" + textBoxExt1.Text + "%'");

                                break;
                        }

                        lstSokRes.Items.Clear();

                        lstSokRes.Items.Add("Fant " + dt.Rows.Count + " enheter");

                        foreach (DataRow row in dt.Rows)
                        {
                            lstSokRes.Items.Add("Navn:" + row.Field<string>(2));
                            lstSokRes.Items.Add("Strekkode: " + row.Field<int>(1));
                            lstSokRes.Items.Add("Antall: " + row.Field<int>(3));
                            lstSokRes.Items.Add("");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dt.Dispose();
                    }
                }
                else
                {
                    try
                    {
                        switch (cmbSokLager.SelectedIndex)
                        {
                            case 0:

                                dt = DB.Select("SELECT * FROM VareTrondheim WHERE navn LIKE '%" + textBoxExt1.Text + "%'");
                                break;

                            case 1:

                                dt = DB.Select("SELECT * FROM VareOslo WHERE navn LIKE '%" + textBoxExt1.Text + "%'");
                                break;

                            case 2:

                                dt = DB.Select("SELECT * FROM VareStavanger WHERE navn LIKE '%" + textBoxExt1.Text + "%'");

                                break;
                        }

                        lstSokRes.Items.Clear();

                        lstSokRes.Items.Add("Fant " + dt.Rows.Count + " enheter");

                        foreach (DataRow row in dt.Rows)
                        {
                            lstSokRes.Items.Add("Navn:" + row.Field<string>(2));
                            lstSokRes.Items.Add("Strekkode: " + row.Field<int>(1));
                            lstSokRes.Items.Add("Antall: " + row.Field<int>(3));
                            lstSokRes.Items.Add("");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dt.Dispose();
                    }

                }
            }
        }

        private void btnSlett_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbLager.SelectedIndex)
                {
                    case 0:
                        DB.Delete("DELETE FROM VareTrondheim WHERE navn='" + cmbVare.SelectedItem.ToString() + "'");
                        break;
                    case 1:
                        DB.Delete("DELETE FROM VareOslo WHERE navn='" + cmbVare.SelectedItem.ToString() + "'");
                        break;
                    case 2:
                        DB.Delete("DELETE FROM VareStavanger WHERE navn='" + cmbVare.SelectedItem.ToString() + "'");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
