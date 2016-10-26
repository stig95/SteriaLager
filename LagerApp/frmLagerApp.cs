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

/// <summary>
/// If at first u dont succeed, call it version 1.0.0
/// </summary>

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
            tabAddUsr.Image = Core.Properties.Resources.User_Add;
            tabEditUsr.Image = Core.Properties.Resources.User_Modify;
            


            UsrNfo();
            PopStorageOverview();

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
                if (txtVareNavn.Text.Length > 2 && !(txtVareNavn.Text.Any(char.IsDigit)))
                {
                    if (intKodeStrek.IntegerValue.ToString().Length == 13 || intKodeStrek.IntegerValue.ToString().Length == 8)
                    {
                        if (!(intAntall.IntegerValue == 0))
                        {
                            if (!(cmbLagerAddVare.SelectedIndex == -1))
                            {
                                switch (cmbLagerAddVare.SelectedIndex)
                                {
                                    case 0:

                                        DB.Insert("INSERT INTO `VareTrondheim`(`strekkode`, `navn`, `antall`) VALUES (" + intKodeStrek.IntegerValue.ToString() + ",'"
                                                                                                                        + txtVareNavn.Text + "',"
                                                                                                                        + intAntall.IntegerValue.ToString() + ")");
                                        break;

                                    case 1:

                                        DB.Insert("INSERT INTO `VareOslo`(`strekkode`, `navn`, `antall`) VALUES (" + intKodeStrek.IntegerValue.ToString() + ",'"
                                                                                                                   + txtVareNavn.Text + "',"
                                                                                                                   + intAntall.IntegerValue.ToString() + ")");
                                        break;

                                    case 2:

                                        DB.Insert("INSERT INTO `VareStavanger`(`strekkode`, `navn`, `antall`) VALUES (" + intKodeStrek.IntegerValue.ToString() + ",'"
                                                                                                                        + txtVareNavn.Text + "',"
                                                                                                                        + intAntall.IntegerValue.ToString() + ")");
                                        break;
                                }

                                MessageBox.Show("Vare '" + txtVareNavn.Text + "' lagt til hos " + cmbLagerAddVare.SelectedItem.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Du må velge lager");
                                return;
                            }
                        }else
                        {
                            MessageBox.Show("Antall kan ikke være 0");
                            return;
                        }

                    }else
                    {
                        MessageBox.Show("EAN koden må være 13 eller 8 siffre");
                        return;
                    }
                }else
                {
                    MessageBox.Show("Varen må ha ett gyldig navn (NonNumeric) > 2");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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

        private bool IsNumeric(string input)
        {
            int output;
            return int.TryParse(input, out output);
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

        void UsrNfo()
        {
            DataTable dt = new DataTable();
            try
            {
                int tot = DB.Count("SELECT COUNT(Bruker_id) FROM Brukere");
                dt = DB.Select("SELECT Bruker_id, brukernavn, email, kontor, stilling FROM Brukere");

                lstUsrNfo.Items.Add("Brukerinformasjon");
                lstUsrNfo.Items.Add("Det er totalt " + tot + " registrerte brukere.");
                lstUsrNfo.Items.Add("");

                foreach (DataRow row in dt.Rows)
                {
                    lstUsrNfo.Items.Add("Brukernavn: " + row.Field<string>(1) + " ID: " + row.Field<int>(0));
                    lstUsrNfo.Items.Add("Epost: " + row.Field<string>(2));
                    switch (row.Field<int>(3))
                    {
                        case 1:
                            lstUsrNfo.Items.Add("Kontor: Trondheim");
                            break;
                        case 2:
                            lstUsrNfo.Items.Add("Kontor: Oslo");
                            break;
                        case 3:
                            lstUsrNfo.Items.Add("Kontor: Stavanger");
                            break;
                        default:
                            lstUsrNfo.Items.Add("Office undetermined");
                            break;
                    }
                    if (row.Field<string>(4) == "admin")
                    {
                        lstUsrNfo.Items.Add("Stilling: Administrator");

                    }else if(row.Field<string>(4) == "ansatt")
                    {
                        lstUsrNfo.Items.Add("Stilling: Ansatt");

                    }
                    lstUsrNfo.Items.Add("");
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

        void PopStorageOverview()
        {
            try
            {
                DBgridOslo.DataSource = DB.Select("SELECT * FROM VareOslo");
                DBgridTrondheim.DataSource = DB.Select("SELECT * FROM VareTrondheim");
                DBgridStavanger.DataSource = DB.Select("SELECT * FROM VareStavanger");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegUsr_Click(object sender, EventArgs e)
        {
            //txtbox2 = usrname
            //txtbx3/4 = pw
            //txtbx5 = epost

            try
            {
                if (textBoxExt2.Text.Length > 5)
                {
                    if (textBoxExt3.Text == textBoxExt4.Text)
                    {
                        if (Core.Mail.Validate.Mail(textBoxExt5.Text))
                        {
                            if (cmbKontor.SelectedIndex > -1)
                            {
                                if (cmbStilling.SelectedIndex > -1)
                                {
                                    Core.User.Create.User(textBoxExt2.Text, textBoxExt3.Text, textBoxExt5.Text, cmbStilling.SelectedIndex, cmbKontor.SelectedIndex);
                                    MessageBox.Show("Bruker " + textBoxExt2.Text + "opprettet");
                                }
                                else
                                {
                                    MessageBox.Show("Vennligst velg en gyldig stilling");
                                    return;
                                }
                                
                            }else
                            {
                                MessageBox.Show("Vennligst velg gyldig kontor");
                                return;
                            }
                            
                        }else
                        {
                            MessageBox.Show("Eposten er ikke gyldig");
                            return;
                        }
                        
                    }else
                    {
                        MessageBox.Show("Passordene må være like");
                        return;
                    }
                }else
                {
                    MessageBox.Show("Brukernavn må være lengre enn 5 bokstaver");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                UsrNfo();
            }
            
            
        }

        private void cmbEndreUsrKontor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                switch (cmbEndreUsrKontor.SelectedIndex)
                {
                    case 0:
                        dt = DB.Select("SELECT brukernavn FROM Brukere Where kontor=1");
                        break;
                    case 1:
                        dt = DB.Select("SELECT brukernavn FROM Brukere Where kontor=2");
                        break;
                    case 2:
                        dt = DB.Select("SELECT brukernavn FROM Brukere Where kontor=3");
                        break;
                }
                foreach (DataRow row in dt.Rows)
                {
                    cmbUsrEndre.Items.Add(row.Field<string>(0));
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

        private void cmbUsrEndre_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = DB.Select("SELECT * FROM Brukere WHERE brukernavn='" + cmbUsrEndre.SelectedItem.ToString() + "'");

                foreach (DataRow row in dt.Rows)
                {
                    lstUsrEndreNfo.Items.Add("Brukernavn: " + row.Field<string>(1));
                    lstUsrEndreNfo.Items.Add("Bruker ID: " + row.Field<int>(0));
                    lstUsrEndreNfo.Items.Add("Epost: " + row.Field<string>(4));

                    switch (row.Field<int>(5))
                    {
                        case 1:
                            lstUsrEndreNfo.Items.Add("Kontor: Trondheim");
                            break;
                        case 2:
                            lstUsrEndreNfo.Items.Add("Kontor: Oslo");
                            break;
                        case 3:
                            lstUsrEndreNfo.Items.Add("Kontor: Stavanger");
                            break;
                        default:
                            lstUsrEndreNfo.Items.Add("Kontor: N/A");
                            break;
                    }

                    
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

        private void cmbEndreLager_Click(object sender, EventArgs e)
        {
            cmbEndreLager.Items.Clear();
            DataTable dt = new DataTable();

            try
            {
                dt = DB.Select("SELECT `by` FROM `kontor`");

                foreach(DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        cmbEndreLager.Items.Add(Convert.ToString(row[column]));
                    }
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

        private void cmbEndreVare_Click(object sender, EventArgs e)
        {
            switch (cmbEndreLager.SelectedIndex)
                
            {
                case 0: //Trondheim
                    cmbEndreVare.Items.Clear();
                    DataTable dt = new DataTable();

                    try
                    {
                        dt = DB.Select("SELECT `navn` FROM `VareTrondheim`");

                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                cmbEndreVare.Items.Add(Convert.ToString(row[column]));
                            }
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

                    break;
                case 1: //Stavanger
                    cmbEndreVare.Items.Clear();
                    DataTable dt2 = new DataTable();

                    try
                    {
                        dt2 = DB.Select("SELECT `navn` FROM `VareStavanger`");

                        foreach (DataRow row in dt2.Rows)
                        {
                            foreach (DataColumn column in dt2.Columns)
                            { 
                                cmbEndreVare.Items.Add(Convert.ToString(row[column]));
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dt2.Dispose();
                    }
                    break;
                case 2: // oslo
                    cmbEndreVare.Items.Clear();
                    DataTable dt3 = new DataTable();

                    try
                    {
                        dt3 = DB.Select("SELECT `navn` FROM `VareOslo`");

                        foreach (DataRow row in dt3.Rows)
                        {
                            foreach (DataColumn column in dt3.Columns)
                            {
                                cmbEndreVare.Items.Add(Convert.ToString(row[column]));
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dt3.Dispose();
                    }
                    break;
                    
                default:
                    //Skriv error
                    break;
            }
        }

        private void cmbEndreVare_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (cmbEndreVare.SelectedIndex)
            {
                case 0: //Trondheim
                    lstVareEndre.Items.Clear();
                    DataTable dt = new DataTable();

                    try
                    {
                        dt = DB.Select("SELECT navn, Strekkode, antall from vareTrondheim where navn = " + cmbEndreVare.Text);

                        foreach (DataRow row in dt.Rows)
                        {
                            MessageBox.Show(Convert.ToString(row));

                            foreach (DataColumn column in dt.Columns)
                            {
                                lstVareEndre.Items.Add(Convert.ToString(row[column]));
                            }
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


                    break;
                case 1: //Stavanger
                    lstVareEndre.Items.Clear();
                    DataTable dt2 = new DataTable();

                    try
                    {
                        dt2 = DB.Select("SELECT navn, Strekkode, antall from vareStavanger where navn = " + cmbEndreVare.Text);

                        foreach (DataRow row in dt2.Rows)
                        {
                            MessageBox.Show(Convert.ToString(row));

                            foreach (DataColumn column in dt2.Columns)
                            {
                                lstVareEndre.Items.Add(Convert.ToString(row[column]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dt2.Dispose();
                    }

                    break;
                case 2: // oslo
                    lstVareEndre.Items.Clear();
                    DataTable dt3 = new DataTable();

                    try
                    {
                        dt3 = DB.Select("SELECT navn, Strekkode, antall from vareOslo where navn = " + cmbEndreVare.Text);

                        foreach (DataRow row in dt3.Rows)
                        {
                            MessageBox.Show(Convert.ToString(row));

                            foreach (DataColumn column in dt3.Columns)
                            {
                                lstVareEndre.Items.Add(Convert.ToString(row[column]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dt3.Dispose();
                    }

                    break;
                default:
                    //Skriv error
                    break;
            }




        }
    }
    }
    

