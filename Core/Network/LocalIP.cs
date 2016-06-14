using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Core.Network
{
    public static class LocalIP
    {
        public static string Get()
        {
            try
            {
                IPHostEntry host;
                string localIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                    }
                }

                return localIP;
            }
            catch (Exception ex)
            {
                return ex.Message + ":" + ex.HResult;
                throw new Exception("");
            }
            
        }
    }
}
