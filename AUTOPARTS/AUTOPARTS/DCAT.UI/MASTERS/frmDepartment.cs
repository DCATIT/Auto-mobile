using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.MODELS;
using AUTOPARTS.DCAT.BL.MASTERS;
using AUTOPARTS.DCAT.UI.SEARCH;


namespace AUTOPARTS.UI
{
    public partial class FRMDEPARTMENT : Form
    {
        MainWindow mainwindow;
        
        public FRMDEPARTMENT(MainWindow mw)
        {
            InitializeComponent();
            mainwindow = mw;
        }

        public static int lodd = 0;

        BL_Department department = new BL_Department();

        private void DEPARTMENT_Load(object sender, EventArgs e)
        {
            lodd = 1;
            FormMode(1); // Sets the toolstrip button Vissibility            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            lodd = 0;
            //base.OnFormClosing(e);
        }
       
        private void TextFieldMode(int mode) 
        {
            switch (mode)
            {
                //Add Mode
                case 1:
                    txtID.Enabled = true;
                    txtName.Enabled = true;                    
                    break;

                //Edit Mode
                case 2:
                    txtID.Enabled = false;
                    txtName.Enabled = true;
                    break;
                //View Mode
                case 3:
                    txtID.Enabled = false;
                    txtName.Enabled = false;
                    break;
                //Add Mode
                default:
                    txtID.Enabled = true;
                    txtName.Enabled = true;                    
                    break;
            }
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

        private void ClearTextFields()
        {
            txtID.Clear();
            txtName.Clear();
        }

        public int ValidateFields()
        {
            int retVal = 0;
            return retVal;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            int retVal = -1;

            if (e.KeyValue == 13)
            {

                retVal = department.IsExists(txtID);

                if (retVal == 1)
                {
                    department.FillForm(txtID, txtName);
                    FormMode(3);
                    TextFieldMode(3);
                }
                else
                {
                    MessageBox.Show("New Item !");
                    txtName.Focus();
                }

            }
        }

        private void tbbClose_Click(object sender, EventArgs e)
        {
            lodd = 0;
            this.Close();
        }

        private void tbbAdd_Click(object sender, EventArgs e)
        {
            //If validation pass

            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                retVal = department.InsertData(txtID, txtName);

                // If Insertion Successs
                if (retVal == 1)
                {
                    //Show some message.
                    MessageBox.Show("Insertion Success !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    ClearTextFields();
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

                retVal = department.DeleteData(txtID, txtName);

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

                retVal = department.UpdateData(txtID, txtName);

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
            txtID.Focus();
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;

          frmScrDepartment frmSearch = new frmScrDepartment(this, 1, mainwindow);

            if (frmScrDepartment.lodd == 0)
            {
                frmSearch.Show();
            }
            else
            {
                frmSearch.BringToFront();
            }     
        }

        private void tbbPrint_Click(object sender, EventArgs e)
        {
            FormMode(2);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (lodd != 0)
            {
                int retVal = -1;
                retVal = department.IsExists(txtID);

                if (retVal == 1)
                {
                    department.FillForm(txtID, txtName);
                    FormMode(3);
                    TextFieldMode(3);
                }
                else
                {
                    MessageBox.Show("New Item !");
                    txtName.Focus();
                }
            }
            else { }
        }

        public void setDepartment(string searchID)
        {
            if (searchID != "")
            {
                TextFieldMode(1);
                txtID.Text = searchID;
                txtID.Focus();
            }
            else
            {
                MessageBox.Show("You did not select ID from department table !!");
            }
            FormMode(3);
        }


        //private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        //}
    
    }
}
