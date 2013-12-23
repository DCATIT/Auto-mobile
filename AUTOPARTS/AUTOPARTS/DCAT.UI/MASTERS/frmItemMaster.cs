using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.BL.MASTERS;
using AUTOPARTS.DCAT.VALIDATION;

namespace AUTOPARTS.DCAT.UI.MASTERS
{
    public partial class itemMaster : Form
    {
        MainWindow mainwindow;

        public itemMaster(MainWindow mw)
        {
            InitializeComponent();
            mainwindow = mw;
        }

        public static int lodd = 0;
        
        BL_ItemMaster bl_itemmaster = new BL_ItemMaster();

        private void itemMaster_Load(object sender, EventArgs e)
        {
            lodd = 1;
            FormMode(1);
            TextFieldMode(1);
            ClearTextFields();
            //chbGenStat.Checked = true;
        }

        private void tbbAdd_Click(object sender, EventArgs e)
        {
            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {

                int retVal = -1;

                retVal = bl_itemmaster.InsertData(txtItmCode, txtItmDesc, txtPtNo, txtPtName, txtAltPtNo, txtAltPtName, txtSpecial, chbGenStat,
                    cmbUom, txtBin, txtSubCatCode, txtSupCode, txtBatchNo, txtSellingPrice, txtCostPrice, rdbActive,rdbInactive );

                // If Insertion Successs
                if (retVal == 0)
                {
                    //Show some message.
                    MessageBox.Show("Insertion Success !", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    TextFieldMode(1);
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
            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {
                int retVal = -1;

                retVal = bl_itemmaster.DeleteData(txtItmCode);

                // If Update Successs
                if (retVal == 0)
                {
                    //Show some message.
                    MessageBox.Show("Delete Success !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("Delete Error !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbbSave_Click(object sender, EventArgs e)
        {
            int validity = -1;

            validity = ValidateFields();

            if (validity == 0)
            {
                int retVal = -1;

                retVal = bl_itemmaster.UpdateData(txtItmCode, txtItmDesc, txtPtNo, txtPtName, txtAltPtNo, txtAltPtName, txtSpecial, chbGenStat,
                    cmbUom, txtBin, txtSubCatCode, txtSupCode, txtBatchNo, txtSellingPrice, txtCostPrice, rdbActive, rdbInactive);

                // If Update Successs
                if (retVal == 0)
                {
                    //Show some message.
                    MessageBox.Show("Update Success !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMode(1);
                    TextFieldMode(1);
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("Update Error !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbbReset_Click(object sender, EventArgs e)
        {
            FormMode(1);
            ClearTextFields();
            TextFieldMode(1);

        }

        private void tbbSearch_Click(object sender, EventArgs e)
        {
            frmScrItemMaster itmsearch = new frmScrItemMaster(mainwindow,this);
            itmsearch.MdiParent  = mainwindow;
            itmsearch.Show();
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

        private void chbGenStat_CheckedChanged(object sender, EventArgs e)
        {
            string AGItemCode;

            if (chbGenStat.Checked)
            {
                if (txtItmDesc.TextLength==0)
                {
                    AGItemCode = bl_itemmaster.GetAutoGenaratedItemID();
                    txtItmCode.Text = AGItemCode;
                    txtItmCode.Enabled = false;                    
                }

            }
            else
            {
                txtItmCode.Text = "";
                txtItmCode.Enabled = true;
            }
        }

        private void txtItmCode_Leave(object sender, EventArgs e)
        {
            if (txtItmCode.Text != "")
            {
                CheckCodeExist(txtItmCode.Text);
            }
        }

        private void txtItmCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtItmCode.Text != "")
                {
                    CheckCodeExist(txtItmCode.Text);
                }
            }
        }

        private int ValidateFields()
        {
            int x = 0;

            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
            if (x==0)
            {
                x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                if (x == 0)
                {
                    x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                    if (x == 0)
                    {
                        x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                        if (x == 0)
                        {
                            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                            if (x == 0)
                            {
                                x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                if (x == 0)
                                {
                                    x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                    if (x == 0)
                                    {
                                        x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                        if (x == 0)
                                        {
                                            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                            if (x == 0)
                                            {
                                                x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                if (x == 0)
                                                {
                                                    x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                    if (x == 0)
                                                    {
                                                        x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                        if (x == 0)
                                                        {
                                                            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                            if (x == 0)
                                                            {
                                                                x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                if (x == 0)
                                                                {
                                                                    x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                    if (x == 0)
                                                                    {
                                                                        x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                        if (x == 0)
                                                                        {
                                                                            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                            if (x == 0)
                                                                            {
                                                                                x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                if (x == 0)
                                                                                {
                                                                                    x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                    if (x == 0)
                                                                                    {
                                                                                        x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                        if (x == 0)
                                                                                        {
                                                                                            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                            if (x == 0)
                                                                                            {
                                                                                                x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                                if (x == 0)
                                                                                                {
                                                                                                    x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                                    if (x == 0)
                                                                                                    {
                                                                                                        x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                                        if (x == 0)
                                                                                                        {
                                                                                                            x = VALIDITY.StringValidation(txtItmCode.Text, 'M', "AN", "LU", 3, 10);
                                                                                                        }
                                                                                                        else
                                                                                                        {

                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {

                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {

                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {

                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {

                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {

                                                                                    }
                                                                                }
                                                                                else
                                                                                {

                                                                                }
                                                                            }
                                                                            else
                                                                            {

                                                                            }
                                                                        }
                                                                        else
                                                                        {

                                                                        }
                                                                    }
                                                                    else
                                                                    {

                                                                    }
                                                                }
                                                                else
                                                                {

                                                                }
                                                            }
                                                            else
                                                            {

                                                            }
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                    else
                                                    {

                                                    }
                                                }
                                                else
                                                {

                                                }
                                            }
                                            else
                                            {

                                            }
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

            }

            Console.WriteLine(x);

            return x;
        }

        private void ClearTextFields()
        {
            txtItmCode.Text = "";
            txtItmDesc.Text = "";
            txtPtNo.Text = "";
            txtPtName.Text = "";
            txtAltPtNo.Text = "";
            txtAltPtName.Text = "";
            txtSpecial.Text = "";
            chbGenStat.Checked = true;
            cmbUom.Text = "";
            txtBin.Text = "";            
            txtSupCode.Text = "";
            lblSupName.Text = "";
            lblCurrentQty.Text = "";
            txtBatchNo.Text = "";
            txtSellingPrice.Text = "";
            txtCostPrice.Text = "";
            rdbActive.Checked = false;
            rdbInactive.Checked = false;

            txtDepCode.Text = "";
            lblDepName.Text = "";
            txtSubDepCode.Text = "";
            lblSubDepName.Text = "";
            txtCatCode.Text = "";
            lblCatName.Text = "";
            txtSubCatCode.Text = "";
            lblSubCatName.Text = "";

            txtSPtNo.Text = "";
            txtSPtName.Text = "";

            txtOpnQty.Text = "";
            txtPurQty.Text = "";
            txtPurRetQty.Text = "";
            txtSaleQty.Text = "";
            txtSalRetQty.Text = "";
            txtDmgQty.Text = "";

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
                    //txtItmCode.Enabled = true;
                    txtItmDesc.Enabled = true;
                    txtPtNo.Enabled = true;
                    txtPtName.Enabled = true;
                    txtAltPtNo.Enabled = true;
                    txtAltPtName.Enabled = true;
                    txtSpecial.Enabled = true;
                    chbGenStat.Enabled = true;
                    cmbUom.Enabled = true;
                    txtBin.Enabled = true;
                    txtSupCode.Enabled = true;
                    txtBatchNo.Enabled = true;
                    txtSellingPrice.Enabled = true;
                    txtCostPrice.Enabled = true;
                    rdbActive.Enabled = true;
                    rdbInactive.Enabled = true;

                    txtDepCode.Enabled = true;
                    txtSubDepCode.Enabled = true;
                    txtCatCode.Enabled = true;
                    txtSubCatCode.Enabled = true;

                    txtSPtNo.Enabled = true;
                    txtSPtName.Enabled = true;

                    txtOpnQty.Enabled = true;
                    txtPurQty.Enabled = true;
                    txtPurRetQty.Enabled = true;
                    txtSaleQty.Enabled = true;
                    txtSalRetQty.Enabled = true; ;
                    txtDmgQty.Enabled = true;
                    break;

                //Edit Mode
                case 2:
                    //txtItmCode.Enabled = false;
                    chbGenStat.Enabled = false;
                    txtItmDesc.Enabled = true;
                    txtPtNo.Enabled = true;
                    txtPtName.Enabled = true;
                    txtAltPtNo.Enabled = true;
                    txtAltPtName.Enabled = true;
                    txtSpecial.Enabled = true;
                    cmbUom.Enabled = true;
                    txtBin.Enabled = true;
                    txtSupCode.Enabled = true;
                    txtBatchNo.Enabled = true;
                    txtSellingPrice.Enabled = true;
                    txtCostPrice.Enabled = true;
                    rdbActive.Enabled = true;
                    rdbInactive.Enabled = true;

                    txtDepCode.Enabled = true;
                    txtSubDepCode.Enabled = true;
                    txtCatCode.Enabled = true;
                    txtSubCatCode.Enabled = true;

                    txtSPtNo.Enabled = true;
                    txtSPtName.Enabled = true;

                    txtOpnQty.Enabled = true;
                    txtPurQty.Enabled = true;
                    txtPurRetQty.Enabled = true;
                    txtSaleQty.Enabled = true;
                    txtSalRetQty.Enabled = true; ;
                    txtDmgQty.Enabled = true;
                    break;

                //View Mode
                case 3:
                    txtItmCode.Enabled = false;
                    txtItmDesc.Enabled = false;
                    txtPtNo.Enabled = false;
                    txtPtName.Enabled = false;
                    txtAltPtNo.Enabled = false;
                    txtAltPtName.Enabled = false;
                    txtSpecial.Enabled = false;
                    chbGenStat.Enabled = false;
                    cmbUom.Enabled = false;
                    txtBin.Enabled = false;
                    txtSupCode.Enabled = false;
                    txtBatchNo.Enabled = false;
                    txtSellingPrice.Enabled = false;
                    txtCostPrice.Enabled = false;
                    rdbActive.Enabled = false;
                    rdbInactive.Enabled = false;

                    txtDepCode.Enabled = false;
                    txtSubDepCode.Enabled = false;
                    txtCatCode.Enabled = false;
                    txtSubCatCode.Enabled = false;

                    txtSPtNo.Enabled = false;
                    txtSPtName.Enabled = false;

                    txtOpnQty.Enabled = false;
                    txtPurQty.Enabled = false;
                    txtPurRetQty.Enabled = false;
                    txtSaleQty.Enabled = false;
                    txtSalRetQty.Enabled = false;
                    txtDmgQty.Enabled = false;
                    break;

                default:
                    break;
            }

        }
     
        private void CheckCodeExist(String code) 
        {
            int retVal = -1;

            retVal = bl_itemmaster.IsExists(txtItmCode);

            if (retVal == 0)
            {
                //department.FillForm(txtID, txtName);
                bl_itemmaster.FillForm(txtItmCode, txtItmDesc, txtPtNo, txtPtName, txtAltPtNo, txtAltPtName, rdbActive, rdbInactive, txtSpecial, chbGenStat,
                    cmbUom, txtBin,txtBatchNo,  txtSupCode,lblSupName,lblCurrentQty, txtCostPrice,txtSellingPrice,
                    txtDepCode,lblDepName,txtSubDepCode,lblSubDepName,txtCatCode,lblCatName,txtSubCatCode,lblSubCatName,
                    txtSPtNo,txtSPtName,txtOpnQty,txtPurQty,txtPurRetQty,txtSaleQty,txtSalRetQty,txtDmgQty);

                FormMode(3);
                TextFieldMode(3);
            }
            else
            {
                txtItmDesc.Focus();
                MessageBox.Show("New Item !");
            }        
        }
                
        public void SetSearchedID(String SearchedCode)
        {
            if (SearchedCode != "")
            {
                chbGenStat.Checked = false;
                txtItmCode.Text = SearchedCode;
                txtItmCode.Focus();
            }
            else
            {
                MessageBox.Show("You did not select ID from Search View !!");
            }
            FormMode(1);
        }
    }

}
