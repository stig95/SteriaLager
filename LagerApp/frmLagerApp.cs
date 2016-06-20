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

namespace LagerApp
{
    public partial class frmLagerApp : Syncfusion.Windows.Forms.MetroForm
    {
        public frmLagerApp()
        {
            InitializeComponent();
            ShowIcon = false;
            Text = null;

            tabPageAdv1.Image = Core.Properties.Resources.sslogotransparent;
            CaptionImages.FindByName("SSLogoTop").Image = Core.Properties.Resources.sslogotransparent;

        }
    }
}