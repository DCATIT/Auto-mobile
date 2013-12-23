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
    public partial class frmSalesRep : Form
    {
        public frmSalesRep()
        {
            InitializeComponent();
        }

        public static int lodd = 0;

        private void SalesRep_Load(object sender, EventArgs e)
        {
            lodd = 1;
            FormMode(1);
        }

        private void tbbAdd_Click(object sender, EventArgs e)
        {
            FormMode(2);
        }

        private void tbbEdit_Click(object sender, EventArgs e)
        {
            FormMode(2);
        }

        private void tbbDelete_Click(object sender, EventArgs e)
        {
            FormMode(1);
        }

        private void tbbSave_Click(object sender, EventArgs e)
        {
            FormMode(1);
        }

        private void tbbReset_Click(object sender, EventArgs e)
        {
            FormMode(1);
        }

        private void tbbSearch_Click(object sender, EventArgs e)
        {
            FormMode(3);
        }

        private void tbbPrint_Click(object sender, EventArgs e)
        {
            FormMode(2);
        }

        private void tbbClose_Click(object sender, EventArgs e)
        {
            lodd = 0;
            this.Close();
        }

        private void FormMode(int mode)
        {
            switch (mode)
            {
                //Add Mode
                case 1:
                    tbbClose.Enabled = true;
                    tbbAdd.Enabled = true;
                    tbbEdit.Enabled = false;
                    tbbSave.Enabled = false;
                    tbbReset.Enabled = true;
                    tbbDelete.Enabled = false;
                    tbbSearch.Enabled = true;
                    break;

                //Edit Mode
                case 2:
                    tbbClose.Enabled = true;
                    tbbAdd.Enabled = false;
                    tbbEdit.Enabled = false;
                    tbbSave.Enabled = true;
                    tbbReset.Enabled = true;
                    tbbDelete.Enabled = false;
                    tbbSearch.Enabled = true;
                    break;
                //View Mode
                case 3:
                    tbbClose.Enabled = true;
                    tbbAdd.Enabled = false;
                    tbbEdit.Enabled = true;
                    tbbSave.Enabled = false;
                    tbbReset.Enabled = true;
                    tbbDelete.Enabled = true;
                    tbbSearch.Enabled = true;
                    break;
                //Add Mode
                default:
                    tbbClose.Enabled = true;
                    tbbAdd.Enabled = true;
                    tbbEdit.Enabled = false;
                    tbbSave.Enabled = false;
                    tbbReset.Enabled = true;
                    tbbDelete.Enabled = false;
                    tbbSearch.Enabled = true;
                    break;
            }
        }

    }
}
