using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AUTOPARTS.DCAT.MODELS;
using System.Windows.Forms;
using AUTOPARTS.DCAT.DAL;
using System.Collections;
using System.Data;

namespace AUTOPARTS.DCAT.BL.MASTERS
{
    public class BL_ItemMaster
    {

        Model_ItemMaster mod_itemmaster = new Model_ItemMaster();
        Model_CurrentStock mod_crntstock = new Model_CurrentStock();
        DAL_ItemMaster dal_itemmaster = new DAL_ItemMaster();


        public int InsertData(TextBox txtITEMCODE, TextBox txtITEMDESCRIPTION, TextBox txtPARTNO, TextBox txtPARTNAME,
            TextBox txtALTPARTNO, TextBox txtALTPARTNAME, TextBox txtSPECIAL, CheckBox chbGENSTATUS, ComboBox cmbUOM,
            TextBox txtBIN, TextBox txtSUBCATID, TextBox txtSUP_CODE, TextBox txtBatch, TextBox txtSELLINGPRICE,
            TextBox txtCOSTPRICE, RadioButton rdbActive, RadioButton rdbInActive)
        {
            int OutVal = -1;

            mod_itemmaster.ITEMCODE = txtITEMCODE.Text;
            mod_itemmaster.ITEMDESCRIPTION = txtITEMDESCRIPTION.Text;
            mod_itemmaster.PARTNO = txtPARTNO.Text;
            mod_itemmaster.PARTNAME = txtPARTNAME.Text;
            mod_itemmaster.ALTPARTNO = txtALTPARTNO.Text;
            mod_itemmaster.ALTPARTNAME = txtALTPARTNAME.Text;
            mod_itemmaster.SPECIAL = txtSPECIAL.Text;
            mod_itemmaster.UOM = cmbUOM.Text;
            mod_itemmaster.BIN = txtBIN.Text;
            mod_itemmaster.SUBCATID = txtSUBCATID.Text;
            int genstat = 0;
            if (chbGENSTATUS.Checked) { genstat = 1; } else { genstat = 0; }
            mod_itemmaster.GENSTATUS = genstat;
            int active = 0;
            if ((rdbActive.Checked == true) && (rdbInActive.Checked == false))
            { active = 1; }
            else { active = 0; }
            mod_itemmaster.ACTIVE = active;
            mod_crntstock.ITEMCODE = txtITEMCODE.Text;
            mod_crntstock.SUP_CODE = txtSUP_CODE.Text;
            mod_crntstock.LOC_CODE = MainWindow.location;
            mod_crntstock.COSTPRICE = Convert.ToDecimal(txtCOSTPRICE.Text);
            mod_crntstock.SELLINGPRICE = Convert.ToDecimal(txtSELLINGPRICE.Text);


            try
            {
                OutVal = dal_itemmaster.InsertData(mod_itemmaster, mod_crntstock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return OutVal;
        }

        public int UpdateData(TextBox txtITEMCODE, TextBox txtITEMDESCRIPTION, TextBox txtPARTNO, TextBox txtPARTNAME,
            TextBox txtALTPARTNO, TextBox txtALTPARTNAME, TextBox txtSPECIAL, CheckBox chbGENSTATUS, ComboBox cmbUOM,
            TextBox txtBIN, TextBox txtSUBCATID, TextBox txtSUP_CODE, TextBox txtBatch, TextBox txtSELLINGPRICE,
            TextBox txtCOSTPRICE, RadioButton rdbActive, RadioButton rdbInActive)
        {
            int OutVal = 1;

            mod_itemmaster.ITEMCODE = txtITEMCODE.Text;
            mod_itemmaster.ITEMDESCRIPTION = txtITEMDESCRIPTION.Text;
            mod_itemmaster.PARTNO = txtPARTNO.Text;
            mod_itemmaster.PARTNAME = txtPARTNAME.Text;
            mod_itemmaster.ALTPARTNO = txtALTPARTNO.Text;
            mod_itemmaster.ALTPARTNAME = txtALTPARTNAME.Text;
            mod_itemmaster.SPECIAL = txtSPECIAL.Text;
            mod_itemmaster.UOM = cmbUOM.Text;
            mod_itemmaster.BIN = txtBIN.Text;
            mod_itemmaster.SUBCATID = txtSUBCATID.Text;
            int genstat = 0;
            if (chbGENSTATUS.Checked) { genstat = 1; } else { genstat = 0; }
            mod_itemmaster.GENSTATUS = genstat;
            int active = 0;
            if ((rdbActive.Checked == true) && (rdbInActive.Checked == false))
            { active = 1; }
            else { active = 0; }
            mod_itemmaster.ACTIVE = active;
            mod_crntstock.ITEMCODE = txtITEMCODE.Text;
            mod_crntstock.SUP_CODE = txtSUP_CODE.Text;
            mod_crntstock.LOC_CODE = MainWindow.location;
            mod_crntstock.COSTPRICE = Convert.ToDecimal(txtCOSTPRICE.Text);
            mod_crntstock.SELLINGPRICE = Convert.ToDecimal(txtSELLINGPRICE.Text);

            try
            {
                OutVal = dal_itemmaster.UpdateData(mod_itemmaster, mod_crntstock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OutVal = 0;
            }

            return OutVal;
        }


        public int DeleteData(TextBox txtITEMCODE)
        {
            int OutVal = -1;

            try
            {
                mod_itemmaster.ITEMCODE = txtITEMCODE.Text;

                OutVal = dal_itemmaster.DeletetData(mod_itemmaster);
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return OutVal;
        }

        public int IsExists(TextBox txtItmCode)
        {
            int OutVal = -1;

            try
            {
                OutVal = dal_itemmaster.CheckItem(txtItmCode.Text);
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return OutVal;
        }

        public string GetAutoGenaratedItemID()
        {
            string AGICODE = dal_itemmaster.GetLastAutoGenaratedNo();

            return AGICODE;
        }

        public void FillForm(TextBox txtItmCode, TextBox txtItmDesc, TextBox txtPtNo, TextBox txtPtName, TextBox txtAltPtNo, 
            TextBox txtAltPtName, RadioButton rdbActive, RadioButton rdbInactive, TextBox txtSpecial, CheckBox chbGenStat, 
            ComboBox cmbUom, TextBox txtBin, TextBox txtBatchNo, TextBox txtSupCode, Label lblSupName, Label lblCurrentQty, 
            TextBox txtCostPrice, TextBox txtSellingPrice, TextBox txtDepCode, Label lblDepName, TextBox txtSubDepCode, 
            Label lblSubDepName, TextBox txtCatCode, Label lblCatName, TextBox txtSubCatCode, Label lblSubCatName, 
            TextBox txtSPtNo, TextBox txtSPtName, TextBox txtOpnQty, TextBox txtPurQty, 
            TextBox txtPurRetQty, TextBox txtSaleQty, TextBox txtSalRetQty, TextBox txtDmgQty)
        {
            ArrayList al = new ArrayList();

            al = dal_itemmaster.GetFormData(txtItmCode.Text);

            Model_ItemMaster mod_itm = new Model_ItemMaster();
            Model_CurrentStock mod_curstk = new Model_CurrentStock();
            Model_Supplier mod_sup = new Model_Supplier();
            Model_Department mod_dep = new Model_Department();
            Model_Subdepartment mod_subdep = new Model_Subdepartment();
            Model_Category mod_cat = new Model_Category();
            Model_SubCategory mod_subcat = new Model_SubCategory();

            mod_itm = (Model_ItemMaster) al[0];
            mod_curstk = (Model_CurrentStock) al[1] ;
            mod_sup = (Model_Supplier) al[2];
            mod_dep = (Model_Department) al[3];
            mod_subdep = (Model_Subdepartment) al[4];
            mod_cat = (Model_Category) al[5];
            mod_subcat = (Model_SubCategory) al[6];

            txtItmCode.Text = mod_itm.ITEMCODE;
            txtItmDesc.Text = mod_itm.ITEMDESCRIPTION;
            txtPtNo.Text = mod_itm.PARTNO;
            txtPtName.Text = mod_itm.PARTNAME;
            txtAltPtNo.Text = mod_itm.ALTPARTNO;
            txtAltPtName.Text = mod_itm.ALTPARTNAME;
            int rVal = mod_itm.ACTIVE ;
            if (rVal == 1) 
            { 
                rdbActive.Checked = true; 
            } 
            else 
            { 
                rdbInactive.Checked = true; 
            }
            
            txtSpecial.Text = mod_itm.SPECIAL;
            
            int GenSt = mod_itm.GENSTATUS;
            if (GenSt == 1)
            {
                chbGenStat.Checked = true;
            }
            else
            {
                chbGenStat.Checked = false;
            }

            cmbUom.Text = mod_itm.UOM;
            txtBin.Text = mod_itm.BIN;
            //txtBatchNo.Text = mod_itm.;
            txtSupCode.Text = mod_sup.SUPCODE;
            lblSupName.Text = mod_sup.COMNAME;
            lblCurrentQty.Text = mod_curstk.SIH.ToString();
            txtCostPrice.Text = mod_curstk.COSTPRICE.ToString();
            txtSellingPrice.Text = mod_curstk.SELLINGPRICE.ToString();
            txtDepCode.Text = mod_dep.DepCode;
            lblDepName.Text = mod_dep.DepName;
            txtSubDepCode.Text = mod_subdep.SUBDEPCODE;
            lblSubDepName.Text = mod_subdep.SUBDEPNAME;
            txtCatCode.Text = mod_cat.CATCODE;
            lblCatName.Text = mod_cat.CATNAME;
            txtSubCatCode.Text = mod_subcat.SUBCATCODE;
            lblSubCatName.Text = mod_subcat.SUBCATNAME;

            if (mod_itm.PARTNO == "" && mod_itm.ALTPARTNO =="")
            {
                txtSPtNo.Text = mod_itm.ITEMCODE;
                txtSPtName.Text = mod_itm.ITEMDESCRIPTION; 
            }
            else if (mod_itm.PARTNO == "" && mod_itm.ALTPARTNO != "")
            {
                txtSPtNo.Text = mod_itm.ALTPARTNO;
                txtSPtName.Text = mod_itm.ALTPARTNAME;                 
            }

            txtOpnQty.Text = mod_crntstock.OPNBAL_QTY.ToString();
            txtPurQty.Text = mod_crntstock.PUR_QTY.ToString();
            txtPurRetQty.Text = mod_crntstock.PURRET_QTY.ToString();
            txtSaleQty.Text = mod_crntstock.SAL_QTY.ToString();
            txtSalRetQty.Text = mod_crntstock.SALRET_QTY.ToString();
            txtDmgQty.Text = mod_crntstock.DMG_QTY.ToString();
        }

        public void SetSearchData(DataGridView dgv, TextBox txtItmCode, TextBox txtIdesc, TextBox txtPtNo, TextBox txtPartName, TextBox txtAltPtNo, TextBox txtAltPtName)
        {
            DataTable dtable = new DataTable();

            dtable.Columns.Add("Item Code");
            dtable.Columns.Add("Item Name");
            dtable.Columns.Add("Part No");
            dtable.Columns.Add("Part Name");
            dtable.Columns.Add("Alt.Part No");
            dtable.Columns.Add("Alt.Part Name");
            dtable.Columns.Add("COST PRICE");
            dtable.Columns.Add("SELLING PRICE");
            dtable.Columns.Add("SIH");

            ArrayList itmList = new ArrayList();

            itmList = dal_itemmaster.GetSearchData(txtItmCode.Text, txtIdesc.Text, txtPtNo.Text, txtPartName.Text, txtAltPtNo.Text, txtAltPtName.Text);

            List<string> al = new List<string>();

            for (int i = 0; i < itmList.Count; i++)
            {
                al = (List<String>) itmList[i];

                dtable.Rows.Add(al.ToArray());


                foreach (var row in dtable.Rows)
                {
                    Console.WriteLine(row.ToString());
                }

            }

            dgv.DataSource = dtable;
        }
    }
}
