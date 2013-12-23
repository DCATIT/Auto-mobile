using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.DAL;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.BL.MASTERS
{
    class BL_Category
    {
        DAL_Category dalCategory = new DAL_Category();
        Model_Category mdlCategory = new Model_Category();

        public int IsExistsDepCode(TextBox txtDepCode)
        {
            int outV = -1;

            try
            {
                outV = dalCategory.CheckDepartment(txtDepCode.Text);

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
                mdlCategory = dalCategory.GetDepartment(txtDepCode.Text);

                txtDepCode.Text = mdlCategory.DEPCODE;
                lblDepName.Text = mdlCategory.DEPNAME;
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
                outV = dalCategory.CheckSubDepartment(txtDepCode.Text, txtSubDepCode.Text);

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
                mdlCategory = dalCategory.GetSubDepartment(txtDepCode.Text, txtSubDepCode.Text, lblSubDepName.Text);

                txtSubDepCode.Text = mdlCategory.SUBDEPCODE;
                lblSubDepName.Text = mdlCategory.SUBDEPNAME;

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
                outV = dalCategory.CheckCategory(txtDepCode.Text, txtSubDepCode.Text, txtCatCode.Text);

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }

            return outV;
        }

        public void FillCategory(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtCatName)
        {
            try
            {
                mdlCategory = dalCategory.GetCategory(txtDepCode.Text, txtSubDepCode.Text, txtCatCode.Text);

                txtCatCode.Text = mdlCategory.CATCODE;
                txtCatName.Text = mdlCategory.CATNAME;

            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        public int InsertData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtCatName)
        {
            int OutVal = 1;

            try
            {
                mdlCategory.DEPCODE = txtDepCode.Text;
                mdlCategory.SUBDEPCODE = txtSubDepCode.Text;
                mdlCategory.CATCODE = txtCatCode.Text;
                mdlCategory.CATNAME = txtCatName.Text;

                OutVal = dalCategory.InsertData(mdlCategory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OutVal = 0;
            }

            return OutVal;
        }

        public int updateData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtCatName)
        {
            int OutVal = -1;

            try
            {
                mdlCategory.DEPCODE = txtDepCode.Text;
                mdlCategory.SUBDEPCODE = txtSubDepCode.Text;
                mdlCategory.CATCODE = txtCatCode.Text;
                mdlCategory.CATNAME = txtCatName.Text;

                OutVal = dalCategory.UpdatetData(mdlCategory);
            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        public int deleteData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtCatCode, TextBox txtCatName)
        {
            int OutVal = -1;

            try
            {
                mdlCategory.DEPCODE = txtDepCode.Text;

                OutVal = dalCategory.DeletetData(mdlCategory);
            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        //public int IsExistsDepCode(TextBox txtDepCode)
        //{
        //    int outV = -1;

        //    try
        //    {
        //        outV = dalCategory.CheckDepartment(txtDepCode.Text);



        //    }
        //    catch (Exception EX)
        //    {
        //        Console.WriteLine(EX.Message);
        //        outV = 0;
        //    }


        //    return outV;
        //}
    }
}
