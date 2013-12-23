using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AUTOPARTS.DCAT.MODELS;
using AUTOPARTS.CONNECTION;


namespace AUTOPARTS.DCAT.BL
{
    public class USERLOGIN
    {
        public static int CHECKUSER(USER usr)
        {
            int retval = -1;

            string UN = usr.UNAME;
            string PW = usr.UPW;


            string dbn;
            string dbpw;
            string dbs;


            dbn = REGISTRYVALUES.getValue("N");
            dbpw = REGISTRYVALUES.getValue("P");
            dbs = REGISTRYVALUES.getValue("S");


            if (UN == "SA")
            {
                retval = 0;
            }
            else 
            {
                retval = 1;
            }

            return retval;
        }

    }
}
