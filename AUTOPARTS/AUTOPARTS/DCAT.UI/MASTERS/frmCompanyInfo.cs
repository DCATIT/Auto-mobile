using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AUTOPARTS.DCAT.UI.MASTERS
{
    public partial class frmCompanyInfo : Form
    {
        public frmCompanyInfo()
        {
            InitializeComponent();
        }

        public static int lodd = 0;

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //If validation pass

            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                //retVal = department.InsertData(txtID, txtName);

                // If Insertion Successs
                if (retVal == 1)
                {
                    //Show some message.
                    MessageBox.Show("Insertion Success !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Insertion Error !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        public int ValidateFields()
        {
            int retVal = 0;
            return retVal;
        }
    }
}
