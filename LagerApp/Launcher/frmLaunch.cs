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
using System.Diagnostics;
using System.Security.Principal;
using System.Net.NetworkInformation;
using LagerApp;
using System.Threading;

namespace Launcher
{
    public partial class frmLaunch : Syncfusion.Windows.Forms.MetroForm
    {
        public frmLaunch()
        {
            InitializeComponent();

            CenterToScreen();
            ShowIcon = false;
            CaptionBarHeight = 48;

            Text = "Sopra Steria Lager";

            CaptionImages.FindByName("SSLogo").Image = Core.Properties.Resources.sslogotransparent;

            pictureBox1.Image = Core.Properties.Resources.usrForgotPW;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        Core.DB.DBConnect db = new Core.DB.DBConnect();

        private void CoreMonitor()
        {
            Application.Run(new Core.Monitor());
        }
        
        private void frmLaunch_Load(object sender, EventArgs e)
        {
            Core.Update.Check.For();

            if (Debugger.IsAttached)
            {
                Thread t = new Thread(new ThreadStart(CoreMonitor));
                t.Start();

                Core.Logging.Write.Info("Debugger attached - Launching Core.Monitor");

            }

            Core.Logging.Write.Info("Main Launcher Initiated");

            try
            {
                db.Insert("INSERT INTO `online`(`user`, `IP(local)`, `IP(external)`, `MAC`) VALUES('" + Core.Network.User.Get() + "','" + Core.Network.LocalIP.Get() + "','" + Core.Network.ExternalIP.Get() + "','" + Core.Network.MAC.Get() + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":" + ex.HResult);
            }
            
        }

        private void frmLaunch_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Delete("DELETE FROM `online` WHERE user='" + Core.Network.User.Get() + "'");
        }

        private void frmLaunch_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F12)
            {
                if (!(Debugger.IsAttached))
                {
                    Thread t = new Thread(new ThreadStart(CoreMonitor));
                    t.Start();

                    Core.Logging.Write.Info("F12 Pressed - Launching Core.Monitor");
                }
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Core.User.Login Login = new Core.User.Login();

            try
            {
                if (Login.Check(textBoxExt1.Text, textBoxExt2.Text) == 1)
                {
                                Thread LagerApp = new Thread(new ThreadStart(
                                delegate
                                {
                                    Application.Run(new frmLagerApp());
                                }));

                                LagerApp.SetApartmentState(ApartmentState.STA);
                                LagerApp.Start();


                    Close();
                }

                else if (Login.Check(textBoxExt1.Text, textBoxExt2.Text) == 2)
                {
                    MessageBox.Show("Yes");
                }
            }
            catch (Exception ex)
            {
                Core.Logging.Write.Warning("Feil brukernavn og/eller passord - : USER:" + textBoxExt1.Text + " : " + ex.Message + " : " + ex.InnerException);
                MessageBox.Show("Feil brukernavn og/eller passord!");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmForgotPW frm = new frmForgotPW();
            frm.Show();
        }
    }
}
