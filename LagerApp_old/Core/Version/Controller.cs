using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Version
{
    class Controller : DB.DBConnect
    {
        public Controller()
        {
            DataTable dt = new DataTable("Version Controller");

            dt = Select("SELECT * FROM VControll WHERE ID=1");

            _Major = dt.Rows[0].Field<int>(1);

            _Minor = dt.Rows[0].Field<int>(2);

            _Build = dt.Rows[0].Field<int>(3);

            _Revision = dt.Rows[0].Field<int>(4);

            if (Debugger.IsAttached)
            {
                int maj = dt.Rows[0].Field<int>(1);
                int min = dt.Rows[0].Field<int>(2);
                int bui = dt.Rows[0].Field<int>(3);
                int rev = dt.Rows[0].Field<int>(4);

                //System.Windows.Forms.MessageBox.Show(Convert.ToString(maj + min + bui + rev));

                if (rev < 30)
                {
                    rev++;

                    Update("UPDATE VControll SET revision=" + rev + " WHERE ID=1");

                }
                else if (rev == 30)
                {
                    rev = 0;
                    bui++;

                    Update("UPDATE VControll SET build=" + bui + ",revision=" + rev + " WHERE ID=1");
                }

                if (bui == 10)
                {
                    min++;
                    bui = 0;

                    Update("UPDATE VControll SET minor=" + min + ",build=" + bui + " WHERE ID =1");
                }

                if (min == 4)
                {
                    maj++;
                    min = 0;

                    Update("UPDATE VControll SET major=" + maj + ",minor=" + min + " WHERE ID=1");
                }

            }




        }


        private int _Major;

        private int _Minor;

        private int _Build;

        private int _Revision;


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

        public string Version
        {
            get
            {
                return _Major + "." + _Minor + "." + _Build + "." + _Revision;
            }
        }

    }
}

