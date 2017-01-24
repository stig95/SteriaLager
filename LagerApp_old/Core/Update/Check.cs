using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Update
{
    public static class Check
    {
        public static void For()
        {
            Assembly Core = Assembly.LoadFrom("Core.dll");

            string v = Core.GetName().Version.ToString();

            if (!v.Contains(GetVersion.Global()))
            {
                DialogResult res = MessageBox.Show("Update available, launch updater?", "Update Available", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(delegate
                    {
                        Application.Run(new frmUpdate());
                    }));
                    t.Start();
                }
                else if (res == DialogResult.No)
                {
                    return;
                }
                
            }
        }
    }
}
