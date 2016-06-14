using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Network
{
    public static class MAC
    {
        public static string Get()
        {
            string macAddr =
                (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

            macAddr = Regex.Replace(macAddr, ".{2}", "$0:");
            macAddr = macAddr.Remove(macAddr.Length - 1);

            return macAddr;
        }
    }
}
