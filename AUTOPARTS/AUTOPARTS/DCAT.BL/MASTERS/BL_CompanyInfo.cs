using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AUTOPARTS.DCAT.BL.MASTERS
{
    public class BL_CompanyInfo
    {
        public int InsertData(TextBox txtdepid, TextBox txtdepname)
        {
            int OutVal = 1;

            try
            {
                //Department.DepCode = txtdepid.Text;
                //Department.DepName = txtdepname.Text;

                //OutVal = DDEP.InsertData(Department);

                //Department = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OutVal = 0;
            }

            return OutVal;
        }

    }
}
