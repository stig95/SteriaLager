using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.User
{
    public class Set
    {
        
        private string _user;
        public string User
        {
            get
            {
                return _user;
            }
            set 
            {
                if (value != null)
                {
                    _user = value;
                }
            }
        }
    }
}
