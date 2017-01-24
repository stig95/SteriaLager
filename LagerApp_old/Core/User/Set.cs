using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.User
{
    public class Set
    {
        
        public string _user;
        public string User
        {
            get
            {
                return _user != null ? _user : "Not Defined";
            }
            set 
            {
                    _user = value;
            }
        }
    }
}
