using System;
using System.Windows.Forms;
using AUTOPARTS.DCAT.DAL;
using AUTOPARTS.DCAT.MODELS;
using System.Collections.Generic;
using System.Data;

namespace AUTOPARTS.DCAT.BL.MASTERS
{
    public class BL_Department
    {
        DAL_Department DDEP = new DAL_Department();
        Model_Department Department = new Model_Department();

        public int InsertData(TextBox txtdepid, TextBox txtdepname)
        {
            int OutVal = 1;

            try
            {
                Department.DepCode = txtdepid.Text;
                Department.DepName = txtdepname.Text;

                OutVal = DDEP.InsertData(Department);

                //Department = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                OutVal = 0;
            }

            return OutVal;
        }

        public int UpdateData(TextBox txtdepid, TextBox txtdepname)
        {
            int OutVal = -1;

            try
            {
                Model_Department department = new Model_Department();

                department.DepCode = txtdepid.Text;
                department.DepName = txtdepname.Text;

                OutVal = DDEP.UpdatetData(department);

                Department = null;

            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        public int DeleteData(TextBox txtdepid, TextBox txtName)
        {
            int OutVal = -1;

            try
            {
                Model_Department department = new Model_Department();

                department.DepCode = txtdepid.Text;

                OutVal = DDEP.DeletetData(department);

                //Department = null;
            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
                OutVal = 0;
            }


            return OutVal;
        }

        public int IsExists(TextBox txtdepid)
        {
            int outV = -1;

            try
            {
                outV = DDEP.CheckDepartment(txtdepid.Text);
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                outV = 0;
            }


            return outV;
        }

        public void FillForm(TextBox txtdepid, TextBox txtdepname)
        {
            try
            {
                Model_Department dep = new Model_Department();

                dep = DDEP.GetDepartment(txtdepid.Text);

                txtdepid.Text = dep.DepCode;
                txtdepname.Text = dep.DepName;
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

        }

        public void SetSearchData(DataGridView dgv,TextBox dname ,TextBox did)
        {
            DataTable dtable = new DataTable();
            List<Model_Department> depListByName = new List<Model_Department>();
            string name;
            string id;

            id = did.Text;
            name = dname.Text;


            if (dname.Text != "")
            {
                depListByName = DDEP.GetSearchDataByName(name);

                dtable.Columns.Add("Department Code");
                dtable.Columns.Add("Department Name");

                foreach (var dep in depListByName)
                {
                    dtable.Rows.Add(dep.DepCode, dep.DepName);
                }

            }
            else if(did.Text != "")
            {
                depListByName = DDEP.GetSearchDataById(id);

                dtable.Columns.Add("Department Code");
                dtable.Columns.Add("Department Name");

                foreach (var dep in depListByName)
                {
                    dtable.Rows.Add(dep.DepCode, dep.DepName);
                }
            
            }
            else
            {
                depListByName = DDEP.GetSearchDataByName(name);

                dtable.Columns.Add("Department Code");
                dtable.Columns.Add("Department Name");

                foreach (var dep in depListByName)
                {
                    dtable.Rows.Add(dep.DepCode, dep.DepName);
                }
                return;
            }
           

            dgv.DataSource = dtable;
            dgv.Columns["Department Code"].Width = 300;
            dgv.Columns["Department Name"].Width = 500;


        } 

    }
}
