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
using System.Net.NetworkInformation;

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
            Font = new Font("Segoe UI", 11, FontStyle.Regular);

            Text = "Sopra Steria Lager";
        }

        Core.DB.DBConnect db = new Core.DB.DBConnect();

        private void CoreMonitor()
        {
            Application.Run(new Monitor());
        }
        
        private void frmLaunch_Load(object sender, EventArgs e)
        {
            if (Debugger.IsAttached)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(CoreMonitor));
                t.Start();
            }

            var macAddr =
    (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
    ).          FirstOrDefault();

            db.Insert("INSERT IGNORE INTO `online`(`user`, `online`) VALUES ('" + Environment.MachineName + "',1)");


            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Core.Properties.Resources.sslogotransparent;
        }

        private void frmLaunch_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Delete("DELETE FROM `online` WHERE user='" + Environment.MachineName + "'");
        }
    }
}
