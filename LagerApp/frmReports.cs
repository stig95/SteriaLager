using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace LagerApp
{
    public partial class frmReports : Syncfusion.Windows.Forms.MetroForm
    {
        public frmReports()
        {
            InitializeComponent();

            ShowIcon = false;
            Text = "Sopra Steria Lager | Rapporter";

            CaptionBarHeight = 48;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
