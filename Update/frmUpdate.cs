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
using System.Threading.Tasks;

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

            string currentVersion, coreVersion, launcherVersion, updaterVersion = null;

            try
            {
                Assembly Core = Assembly.LoadFrom("Core.dll");
                autoLabel1.Text = "Core Version: " + Core.GetName().Version;
                coreVersion = getVersion("https://mrfs.me/sopra/versions/Vcore.txt");

                if (!autoLabel1.Text.Contains(coreVersion))
                {
                    autoLabel5.Text = "New Update Available" + " (" + coreVersion + ")";
                }
                else
                {
                    autoLabel5.Text = "No new version";
                }
            }
            catch (Exception)
            {
                autoLabel1.Text = "Core Version: CND";
            }

            try
            {
                autoLabel2.Text = "Launcher Version: " + FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\Launcher.exe").FileVersion;

                launcherVersion = getVersion("https://mrfs.me/sopra/versions/Vlauncher.txt");

                if (!autoLabel2.Text.Contains(launcherVersion))
                {
                    autoLabel6.Text = "New Update Available" + " (" + launcherVersion + ")";
                }
                else
                {
                    autoLabel6.Text = "No new version";
                }
            }
            catch (Exception)
            {
                autoLabel2.Text = "Launcher Version: CND";
            }

            try
            {
                autoLabel3.Text = "Updater Version: " + Assembly.GetExecutingAssembly().GetName().Version;

                updaterVersion = getVersion("https://mrfs.me/sopra/versions/Vupdater.txt");

                if (!autoLabel3.Text.Contains(updaterVersion))
                {
                    autoLabel7.Text = "New Update Available" + " (" + updaterVersion + ")";
                }
                else
                {
                    autoLabel7.Text = "No new version";
                }
            }
            catch (Exception)
            {
                autoLabel3.Text = "Updater Version: CND";
            }

            try
            {
                autoLabel4.Text = "Main Version: " + FileVersionInfo.GetVersionInfo(Environment.CurrentDirectory + "\\LagerApp.exe").FileVersion;

                currentVersion = getVersion("https://mrfs.me/sopra/versions/Vcurrent.txt");

                if (!autoLabel2.Text.Contains(currentVersion))
                {
                    autoLabel8.Text = "New Update Available" + " (" + currentVersion + ")";
                }
                else
                {
                    autoLabel8.Text = "No new version";
                }
            }
            catch (Exception)
            {
                
            }

           
        }

        public static string getVersion(string adress)
        {
            WebClient WC = new WebClient();
            //Uri vString = new Uri(adress);

            //WC.DownloadStringCompleted += (sender, e) =>
            //{
            
            //    v = e.Result;

            //};

            //WC.DownloadStringAsync(vString);

            return WC.DownloadString(adress);
            
        }
    }
}
