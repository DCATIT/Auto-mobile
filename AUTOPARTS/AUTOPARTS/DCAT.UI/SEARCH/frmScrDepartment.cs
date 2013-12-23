using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.UI;
using AUTOPARTS.DCAT.UI.MASTERS;
using AUTOPARTS.DCAT.BL.MASTERS;

namespace AUTOPARTS.DCAT.UI.SEARCH
{
    public partial class frmScrDepartment : Form
    {
        public static int lodd = 0;
        BL_Department bl_department = new BL_Department();
        MainWindow mainWindow;

        public Object fObject;

        //Intiger is set up according to called window
        public static int calledForm = 0;

        FRMDEPARTMENT ui_department;        // 1 for Department
        Sub_Departments ui_subdepartment;   // 2 for SubDepartment
        category ui_category;               // 3 for Category
        subCategory ui_subcategory;         // 4 for SubCategory
        itemMaster ui_itemmaster;           // 5 for Item master
                                            // 6 for Some other form

        public frmScrDepartment(Object frmObject, int formID, MainWindow main)
        {
            InitializeComponent();
            fObject = frmObject;
            calledForm = formID;
            mainWindow = main;
        }

        private void frmScrDepartment_Load(object sender, EventArgs e)
        {
            this.Parent = mainWindow;
            lodd = 1;
        }
        private void frmScrDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            lodd = 0;
        }
        private void SetFormObject(object fObject, String Code)
        {
            switch (calledForm)
            {
                case 1:
                    ui_department = (FRMDEPARTMENT)fObject;
                    ui_department.setDepartment(Code);
                    break;
                case 2:
                    ui_subdepartment = (Sub_Departments)fObject;
                    //ui_subdepartment.SetSearchedID(Code);
                    break;
                case 3:
                    ui_category = (category)fObject;
                    //ui_subdepartment.SetSearchedID(Code);
                    break;
                case 4:
                    ui_subcategory = (subCategory)fObject;
                    //ui_subdepartment.SetSearchedID(Code);
                    break;
                case 5:
                    ui_itemmaster = (itemMaster)fObject;
                    //ui_subdepartment.SetSearchedID(Code);
                    break;
                default:
                    ui_department = (FRMDEPARTMENT)fObject;
                    ui_department.setDepartment(Code);
                    break;
            }//ui_subcategory
        }

        private void txtDepName_TextChanged(object sender, EventArgs e)
        {
            bl_department.SetSearchData(dataGridView1, txtDepName,txtDepCode);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            int cellIndex = dataGridView1.CurrentCell.RowIndex;
            string code = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            SetFormObject(fObject, code);

            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDepCode_TextChanged(object sender, EventArgs e)
        {
            bl_department.SetSearchData(dataGridView1, txtDepName,txtDepCode);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string code = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            SetFormObject(fObject, code);
            this.Close();
        }
    }
}
