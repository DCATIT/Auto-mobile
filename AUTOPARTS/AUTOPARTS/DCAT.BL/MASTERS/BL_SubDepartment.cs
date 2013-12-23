using System;
using System.Windows.Forms;
using AUTOPARTS.DCAT.DAL;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.BL.MASTERS
{
    public class BL_SubDepartment
    {
        DAL_SubDeparment dalSubDep = new DAL_SubDeparment();
        Model_Subdepartment subDep = new Model_Subdepartment();

        public int InsertData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtSubDepName)
        {
            int OutVal = 1;

            try
            {
                subDep.DEPCODE = txtDepCode.Text;
                subDep.SUBDEPCODE = txtSubDepCode.Text;
                subDep.SUBDEPNAME = txtSubDepName.Text;

                OutVal = dalSubDep.InsertData(subDep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OutVal = 0;
            }

            return OutVal;
        }

        public int updateData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtSubDepName)
        {
            int OutVal = -1;

            try
            {
                subDep.DEPCODE = txtDepCode.Text;
                subDep.SUBDEPCODE = txtSubDepCode.Text;
                subDep.SUBDEPNAME = txtSubDepName.Text;

                OutVal = dalSubDep.UpdatetData(subDep);

                subDep = null;

            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        public int deleteData(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtSubDepName)
        {
            int OutVal = -1;

            try
            {
                subDep.DEPCODE = txtDepCode.Text;

                OutVal = dalSubDep.DeletetData(subDep);

                //Department = null;
            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        public int IsExistsDepCode(TextBox txtDepCode)
        {
            int outV = -1;

            try
            {
                outV = dalSubDep.CheckDepartment(txtDepCode.Text);
               


            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }


            return outV;
        }

        public int IsExistsSubDepCode(TextBox txtDepCode, TextBox txtSubDepCode)
        {
            int outV = -1;

            try
            {
                outV = dalSubDep.CheckSubDepartment(txtDepCode.Text, txtSubDepCode.Text);
                
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
                subDep = dalSubDep.GetDepartment(txtDepCode.Text);

                txtDepCode.Text = subDep.DEPCODE;
                lblDepName.Text = subDep.DEPNAME;
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

         public void FillSubDepartment(TextBox txtDepCode, TextBox txtSubDepCode, TextBox txtSubDepName)
        {
            try
            {
                subDep = dalSubDep.GetSubDepartment(txtDepCode.Text, txtSubDepCode.Text, txtSubDepName.Text);
              
                txtSubDepCode.Text = subDep.SUBDEPCODE;
                txtSubDepName.Text = subDep.SUBDEPNAME;
               
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }
    }
}
