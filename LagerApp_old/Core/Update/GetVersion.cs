using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Update
{
    public static class GetVersion
    {
        public static string Global()
        {
            using (WebClient WC = new WebClient())
            {
                return WC.DownloadString("https://mrfs.me/sopra/versions/Vglobal.txt");
            }
        }
    }
}
