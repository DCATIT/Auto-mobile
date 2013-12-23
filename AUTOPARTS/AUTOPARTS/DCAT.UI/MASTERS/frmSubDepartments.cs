using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.BL.MASTERS;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.UI.MASTERS
{
    public partial class Sub_Departments : Form
    {
        public Sub_Departments()
        {
            InitializeComponent();
            
        }


        BL_SubDepartment blSubDep = new BL_SubDepartment();
        BL_Department blDep = new BL_Department();
        
        public static int lodd;
        
        private void Sub_Departments_Load(object sender, EventArgs e)
        {
            lodd = 1;
            FormMode(1);

        }

        private void tbbAdd_Click(object sender, EventArgs e)
        {
            FormMode(2);
            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                retVal = blSubDep.InsertData(txtDepCode, txtSubDepCode, txtSubDepName);

                // If Insertion Successs
                if (retVal == 1)
                {
                    //Show some message.
                    MessageBox.Show("Insertion Success !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    ClearTextFields();
                    txtDepCode.Focus();
                }
                else
                {
                    MessageBox.Show("Insertion Error !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbbEdit_Click(object sender, EventArgs e)
        {
            FormMode(2);
            TextFieldMode(2);
        }

        private void tbbDelete_Click(object sender, EventArgs e)
        {
            //If validation pass

            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                retVal = blSubDep.deleteData(txtDepCode, txtSubDepCode,txtSubDepName);

                // If Deletion Successs
                if (retVal == 1)
                {
                    //Show some message.
                    MessageBox.Show("Deletion Success !", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    TextFieldMode(1);
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("Deletion Error !", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tbbSave_Click(object sender, EventArgs e)
        {
            //If validation pass

            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                retVal = blSubDep.updateData(txtDepCode, txtSubDepCode, txtSubDepName);

                // If Insertion Successs
                if (retVal == 1)
                {
                    //Show some message.
                    MessageBox.Show("Updation Success !", "Updation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    TextFieldMode(1);
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("Updation Error !", "Updation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            FormMode(1);
        }

        private void tbbReset_Click(object sender, EventArgs e)
        {
            FormMode(1);
            TextFieldMode(1);
            ClearTextFields();
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

        private void TextFieldMode(int mode)
        {
            switch (mode)
            {
                //Add Mode
                case 1:
                    txtDepCode.Enabled = true;
                    txtSubDepCode.Enabled = true;
                    txtSubDepName.Enabled = true;
                    break;

                //Edit Mode
                case 2:
                    txtDepCode.Enabled = false;
                    txtSubDepCode.Enabled = false;
                    txtSubDepName.Enabled = true;
                    break;
                //View Mode
                case 3:
                    txtDepCode.Enabled = false;
                    txtSubDepCode.Enabled = false;
                    txtSubDepName.Enabled = false;
                    break;
                //Add Mode
                default:
                    txtDepCode.Enabled = true;
                    txtSubDepCode.Enabled = true;
                    txtSubDepName.Enabled = true;
                    break;
            }
        }

        public void ClearTextFields()
        {
            txtDepCode.Clear();
            txtSubDepCode.Clear();
            txtSubDepName.Clear();
            lblSubDepCodeError.Text = string.Empty;
            lblDepName.Text = string.Empty;
        }

        public int ValidateFields()
        {
            int retVal = 0;
            return retVal;
        }

        private void txtSubDepCode_Leave(object sender, EventArgs e)
        {
            int retVal = -1;
            retVal = blSubDep.IsExistsSubDepCode(txtDepCode, txtSubDepCode);

            if (retVal == 1)
            {
                blSubDep.FillSubDepartment(txtDepCode, txtSubDepCode, txtSubDepName);
                FormMode(3);
                TextFieldMode(3);
            }
            else
            {
                lblSubDepCodeError.Text = "New SubDepartment";
                txtSubDepCode.Focus();
            }
        }

        private void txtDepCode_KeyDown(object sender, KeyEventArgs e)
        
        {
            int retVal = -1;

            if (e.KeyValue == 13)
            {
                retVal = blSubDep.IsExistsDepCode(txtDepCode);

                if (retVal == 1)
                {
                    blSubDep.FillDepartment(txtDepCode,lblDepName);
                    FormMode(3);
                    TextFieldMode(1);
                    txtSubDepCode.Focus();
                }
                else
                {
                    lblDepName.Text = "Invalid Department Code";
                    txtDepCode.Clear();
                    txtDepCode.Focus();
                }
            }
        }

        private void txtSubDepCode_KeyDown(object sender, KeyEventArgs e)
        {
            int retVal = -1;

            if (e.KeyValue == 13)
            {
                retVal = blSubDep.IsExistsSubDepCode(txtDepCode, txtSubDepCode);

                if (retVal == 1)
                {
                    lblSubDepCodeError.Text = string.Empty;
                    blSubDep.FillSubDepartment(txtDepCode, txtSubDepCode, txtSubDepName);
                    FormMode(3);
                    TextFieldMode(3);
                }
                else
                {
                    lblSubDepCodeError.Text = "New SubDepartment found";
                    //lblSubDepCodeError.ForeColor = FillColor.MoreColors.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                    FormMode(1);
                    txtSubDepName.Focus();
                }
            }
        }

        private void txtDepCode_Leave(object sender, EventArgs e)
        {
            int retVal = -1;

                retVal = blSubDep.IsExistsDepCode(txtDepCode);

                if (retVal == 1)
                {
                    blSubDep.FillDepartment(txtDepCode, lblDepName);
                    FormMode(3);
                    TextFieldMode(1);
                    txtSubDepCode.Focus();
                }
                else
                {
                    lblDepName.Text = "Invalid Department Code";
                    txtDepCode.Clear();
                    txtDepCode.Focus();
                }
        }
    }
}
