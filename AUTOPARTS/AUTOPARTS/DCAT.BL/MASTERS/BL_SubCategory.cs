using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.DAL;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.BL.MASTERS
{
    public class BL_SubCategory
    {
        DAL_SubCategory dalSubCat = new DAL_SubCategory();
        Model_SubCategory mdlSubCat = new Model_SubCategory();

        public int IsExistsDepCode(TextBox txtDepCode)
        {
            int outV = -1;

            try
            {
                outV = dalSubCat.CheckDepartment(txtDepCode.Text);

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }

            return outV;
        }

        public void FillDepartment(TextBox txtDepCode, Label lblDepName)
        {
            try
            {
                mdlSubCat = dalSubCat.GetDepartment(txtDepCode.Text);

                txtDepCode.Text = mdlSubCat.DEPCODE;
                lblDepName.Text = mdlSubCat.DEPNAME;
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        public int IsExistsSubDepCode(TextBox txtDepCode, TextBox txtSubDepCode)
        {
            int outV = -1;

            try
            {
                outV = dalSubCat.CheckSubDepartment(txtDepCode.Text, txtSubDepCode.Text);

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }

            return outV;
        }

        public void FillSubDepartment(TextBox txtDepCode, TextBox txtSubDepCode, Label lblSubDepName)
        {
            try
            {
                mdlSubCat = dalSubCat.GetSubDepartment(txtDepCode.Text, txtSubDepCode.Text, lblSubDepName.Text);

                txtSubDepCode.Text = mdlSubCat.SUBDEPCODE;
                lblSubDepName.Text = mdlSubCat.SUBDEPNAME;

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        public int IsExistsCategory(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode)
        {
            int outV = -1;

            try
            {
                outV = dalSubCat.CheckCategory(txtDepCode.Text, txtSubDepCode.Text, txtCatCode.Text);

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }

            return outV;
        }

        public void FillCategory(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, Label lblCatName)
        {
            try
            {
                mdlSubCat = dalSubCat.GetCategory(txtDepCode.Text, txtSubDepCode.Text, txtCatCode.Text);

                txtCatCode.Text = mdlSubCat.CATCODE;
                lblCatName.Text = mdlSubCat.CATNAME;

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        public int IsExistsSubCategory(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode,TextBox txtSubCatCode)
        {
            int outV = -1;

            try
            {
                outV = dalSubCat.CheckSubCategory(txtDepCode.Text, txtSubDepCode.Text, txtCatCode.Text,txtSubCatCode.Text);

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }

            return outV;
        }

        public void FillSubCategory(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtSubCatCode, TextBox txtSubCatName)
        {
            try
            {
                mdlSubCat = dalSubCat.GetSubCategory(txtDepCode.Text,txtSubDepCode.Text,txtCatCode.Text,txtSubCatCode.Text);

                txtSubCatCode.Text = mdlSubCat.SUBCATCODE;
                txtSubCatName.Text = mdlSubCat.SUBCATNAME;

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        public int InsertData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtSubCatCode, TextBox txtSubCatName)
        {
            int OutVal = 1;

            try
            {
                mdlSubCat.DEPCODE = txtDepCode.Text;
                mdlSubCat.SUBDEPCODE = txtSubDepCode.Text;
                mdlSubCat.CATCODE = txtCatCode.Text;
                mdlSubCat.SUBCATCODE = txtSubCatCode.Text;
                mdlSubCat.SUBCATNAME = txtSubCatName.Text;

                OutVal = dalSubCat.InsertData(mdlSubCat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OutVal = 0;
            }

            return OutVal;
        }

        public int updateData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtSubCatCode, TextBox txtSubCatName)
        {
            int OutVal = -1;

            try
            {
                mdlSubCat.DEPCODE = txtDepCode.Text;
                mdlSubCat.SUBDEPCODE = txtSubDepCode.Text;
                mdlSubCat.CATCODE = txtCatCode.Text;
                mdlSubCat.SUBCATCODE = txtSubCatCode.Text;
                mdlSubCat.SUBCATNAME = txtSubCatName.Text;

                OutVal = dalSubCat.UpdatetData(mdlSubCat);
            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        public int deleteData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtSubCatCode, TextBox txtSubCatName)
        {
            int OutVal = -1;

            try
            {
                mdlSubCat.DEPCODE = txtDepCode.Text;

                OutVal = dalSubCat.DeletetData(mdlSubCat);
            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }
    }
}
