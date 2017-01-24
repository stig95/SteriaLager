using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Core.Update
{
    public static class Download
    {
        static Download()
        {
            using (WebClient WC = new WebClient())
            {
                string Vglobal = WC.DownloadString("https://mrfs.me/sopra/versions/Vglobal.txt");
                WC.DownloadFile("https://mrfs.me/sopra/versions/" + Vglobal + ".zip", Vglobal);

                ZipFile.ExtractToDirectory(Vglobal + ".zip", "update");
            }
        }
    }
}
