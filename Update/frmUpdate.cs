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
using System.Reflection;
using System.Diagnostics;
using System.Net;

namespace Update
{
    public partial class frmUpdate : Syncfusion.Windows.Forms.MetroForm
    {
        public frmUpdate()
        {
            InitializeComponent();

            ShowIcon = false;
            Text = "Mr lobaloba";

            CaptionBarHeight = 32;
        }

        

        private void frmUpdate_Load(object sender, EventArgs e)
        {

            string currentVersion = null;

            getVersion(); 

            try
            {
                Assembly Core = Assembly.LoadFrom("Core.dll");
                autoLabel1.Text = "Core Version: " + Core.GetName().Version;
            }
            catch (Exception)
            {
                autoLabel1.Text = "Core Version: CND";
            }

            try
            {
                autoLabel2.Text = "Launcher Version: " + FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\Launcher.exe").FileVersion;
            }
            catch (Exception)
            {
                autoLabel2.Text = "Launcher Version: CND";
            }

            try
            {
                autoLabel3.Text = "Updater Version: " + Assembly.GetExecutingAssembly().GetName().Version;
            }
            catch (Exception)
            {
                autoLabel3.Text = "Updater Version: CND";
            }

           
        }

        public void getVersion()
        {
            WebClient WC = new WebClient();
            Uri vString = new Uri("https://mrfs.me/school/oopsa/version.txt");

            string v = null;

            WC.DownloadStringCompleted += (sender, e) =>
            {
                v = e.Result;
                autoLabel4.Text = v;
            };

            WC.DownloadStringAsync(vString);
        }
    }
}
