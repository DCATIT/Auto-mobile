using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.BL.MASTERS;

namespace AUTOPARTS.DCAT.UI.MASTERS
{
    public partial class category : Form
    {
        BL_Category blcategory = new BL_Category();

        public category()
        {
            InitializeComponent();
        }

        public static int lodd = 0;

        private void category_Load(object sender, EventArgs e)
        {
            lodd = 1;
            FormMode(1);
        }

        private void tbbAdd_Click(object sender, EventArgs e)
        {
            FormMode(1);
            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                retVal = blcategory.InsertData(txtDepCode, txtSubDepCode, txtCatCode,txtCatName);

                // If Insertion Successs
                if (retVal == 0)
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

        private int ValidateFields()
        {
            int retVal = 0;
            return retVal;
        }

        private void ClearTextFields()
        {
            txtDepCode.Text = string.Empty;
            txtSubDepCode.Text = string.Empty;
            txtCatCode.Text = string.Empty;
            txtCatName.Text = string.Empty;
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

                retVal = blcategory.deleteData(txtDepCode, txtSubDepCode, txtCatCode, txtCatName);

                // If Deletion Successs
                if (retVal == 0)
                {
                    //Show some message.
                    MessageBox.Show("Deletion Success !", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    TextFieldMode(1);
                    ClearTextFields();
                    txtDepCode.Focus();
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

                retVal = blcategory.updateData(txtDepCode, txtSubDepCode, txtCatCode,txtCatName);

                // If Update Successs
                if (retVal == 0)
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
            ClearTextField();
            TextFieldMode(1);
            txtDepCode.Focus();
            
        }

        private void tbbSearch_Click(object sender, EventArgs e)
        {
            FormMode(3);
        }

        private void tbbPrint_Click(object sender, EventArgs e)
        {
            FormMode(2);
        }

        private void tbbClose_Click_1(object sender, EventArgs e)
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
                    txtCatCode.Enabled = true;
                    txtCatName.Enabled = true;
                    break;

                //Edit Mode
                case 2:
                    txtDepCode.Enabled = false;
                    txtSubDepCode.Enabled = false;
                    txtCatCode.Enabled = false;
                    txtCatName.Enabled = true;
                    break;
                //View Mode
                case 3:
                    txtDepCode.Enabled = false;
                    txtSubDepCode.Enabled = false;
                    txtCatCode.Enabled = false;
                    txtCatName.Enabled = false;
                    break;
                //Add Mode
                default:
                    txtDepCode.Enabled = true;
                    txtSubDepCode.Enabled = true;
                    txtCatCode.Enabled = true;
                    txtCatName.Enabled = true;
                    break;
            }
        }

        public void ClearTextField() 
        {
            txtCatCode.Text = string.Empty;
            txtCatName.Text = string.Empty;
            txtDepCode.Text = string.Empty;
            txtSubDepCode.Text = string.Empty;
            lblCatCodeError.Text = string.Empty;
            lblDepName.Text = string.Empty;
            lblSubDepName.Text = string.Empty;
        }

        private void txtDepCode_KeyDown(object sender, KeyEventArgs e)
        {
                int retVal = -1;

                if (e.KeyValue == 13)
                {
                    retVal = blcategory.IsExistsDepCode(txtDepCode);

                    if (retVal == 1)
                    {
                        blcategory.FillDepartment(txtDepCode, lblDepName);
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
                    retVal = blcategory.IsExistsSubDepCode(txtDepCode,txtSubDepCode);

                    if (retVal == 1)
                    {
                        blcategory.FillSubDepartment(txtDepCode,txtSubDepCode,lblSubDepName);
                        FormMode(3);
                        TextFieldMode(1);
                        txtCatCode.Focus();
                    }
                    else
                    {
                        lblSubDepName.Text = "Invalid SubDepartment Code";
                        txtSubDepCode.Clear();
                        txtSubDepCode.Focus();
                    }
                }
            
        }

        private void txtCatCode_KeyDown(object sender, KeyEventArgs e)
        {
                int retVal = -1;

                if (e.KeyValue == 13)
                {
                    retVal = blcategory.IsExistsCategory(txtDepCode,txtSubDepCode,txtCatCode);

                    if (retVal == 1)
                    {
                        blcategory.FillCategory(txtDepCode,txtSubDepCode,txtCatCode,txtCatName);
                        FormMode(3);
                        TextFieldMode(3);
                    }
                    else
                    {
                        lblCatCodeError.Text = "New Category Code";
                        txtCatName.Focus();
                        FormMode(1);
                        TextFieldMode(1);
                    }
                }
        }

        private void txtDepCode_Leave(object sender, EventArgs e)
        {
            int retVal = -1;
                retVal = blcategory.IsExistsDepCode(txtDepCode);

                if (retVal == 1)
                {
                    blcategory.FillDepartment(txtDepCode, lblDepName);
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

        private void txtSubDepCode_Leave(object sender, EventArgs e)
        {
            int retVal = -1;

                retVal = blcategory.IsExistsSubDepCode(txtDepCode, txtSubDepCode);

                if (retVal == 1)
                {
                    blcategory.FillSubDepartment(txtDepCode, txtSubDepCode, lblSubDepName);
                    FormMode(3);
                    TextFieldMode(1);
                    txtCatCode.Focus();
                }
                else
                {
                    lblSubDepName.Text = "Invalid SubDepartment Code";
                    txtSubDepCode.Clear();
                    txtSubDepCode.Focus();
                }
        }

        private void txtCatCode_Leave(object sender, EventArgs e)
        {
            int retVal = -1;

                retVal = blcategory.IsExistsCategory(txtDepCode, txtSubDepCode, txtCatCode);

                if (retVal == 1)
                {
                    blcategory.FillCategory(txtDepCode, txtSubDepCode, txtCatCode, txtCatName);
                    FormMode(3);
                    TextFieldMode(3);
                }
                else
                {
                    lblCatCodeError.Text = "New Category Code";
                    txtCatName.Focus();
                    FormMode(1);
                    TextFieldMode(1);
                }
        }  
    }
}
