using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LagerCore.Initiate;

namespace LagerMain
{
    static class Program
    {
        public static frmSplash frmSplashScreen = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Showw dat splashscreen doeee
            Thread splashT = new Thread(new ThreadStart(
                delegate
                {
                    frmSplashScreen = new frmSplash();
                    Application.Run(frmSplashScreen);
                }));

            splashT.SetApartmentState(ApartmentState.STA);
            splashT.Start();

            //Ran dis main shiiiieet, is guna tak time yoo
            Login.frmLogin frmMain = new Login.frmLogin();
            frmMain.Load += new EventHandler(frmLogin_Load);
            Application.Run(frmMain);

        }

        static void frmLogin_Load(object sender, EventArgs e)
        {
            //close splasheriinooos
            if (frmSplashScreen == null)
            {
                return;
            }

            frmSplashScreen.Invoke(new Action(frmSplashScreen.Close));
            frmSplashScreen.Dispose();
            frmSplashScreen = null;
        }
    }
}
