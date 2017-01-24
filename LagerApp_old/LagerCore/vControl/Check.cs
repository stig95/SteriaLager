using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerCore.vControl
{
    public class Check
    {
        private int _Major;

        private int _Minor;

        private int _Build;

        private int _Revision;

        public Check()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public int Major
        {
            get
            {
                return _Major;

            }
        }

        public int Minor
        {
            get
            {
                return _Minor;
            }
        }

        public int Build
        {
            get
            {
                return _Build;
            }
        }

        public int Revision
        {
            get
            {
                return _Revision;
            }
        }


        
        public override string ToString()
        {
            return _Major + "." + _Minor + "." + _Build + "." + _Revision;
        }
    }
}
