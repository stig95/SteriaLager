using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Network
{
    public static class User
    {
        public static string Get()
        {
            string LocalUser;

            LocalUser = WindowsIdentity.GetCurrent().Name;
            LocalUser = LocalUser.Insert(LocalUser.IndexOf("\\"), "\\");

            return LocalUser;
        }
    }
}
