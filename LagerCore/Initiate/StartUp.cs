using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LagerCore.Initiate
{
    public static class StartUp
    {

        public static void Run()
        {
            try
            {
                Log.Write.Info("Initiate StartUp");
                LagerCore.Initiate.File.DBRead.InitDBRead();

            }
            catch (Exception ex)
            {
                Log.Write.Error(ex.Message);
                MessageBox.Show(ex.Message);
            }
            
        }
        
    }
}
