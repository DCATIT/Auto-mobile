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
using AUTOPARTS.DCAT.LOGIN;
using AUTOPARTS.DCAT.UI.TRANSACTIONS;

namespace AUTOPARTS
{
    public partial class MainWindow : Form
    {
        LoginForm loginForm;
    
        public MainWindow(LoginForm loginform)
        {
            loginForm = loginform;
            InitializeComponent();
            timer1.Start();
        }
        private void dEPARTMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FRMDEPARTMENT(this);
            frm.MdiParent = this;

            if (FRMDEPARTMENT.lodd == 0)
            {
                frm.Show();
            }
            else
            {
                this.BringToFront();
                return;
            }
        }
        private void cATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category catFrm = new category();
            catFrm.MdiParent = this;

            if (category.lodd == 0)
            {
                catFrm.Show();
            }
            else
            {
                this.BringToFront();
                return;
            }
        }
        private void sUBDEPARTMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sub_Departments sabDepFrm = new Sub_Departments();
            sabDepFrm.MdiParent = this;

            if (Sub_Departments.lodd == 0)
            {
                sabDepFrm.Show();
                return;
            }
            else
            {
                sabDepFrm.BringToFront();
                return;
            }
        }
        private void sUBCATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subCategory sabCatFrm = new subCategory();
            sabCatFrm.MdiParent = this;

            if (subCategory.lodd == 0)
            {
                sabCatFrm.Show();
                return;
            }
            else
            {
                sabCatFrm.BringToFront();
                return;
            }
        }

        private void iTEMMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemMaster itemFrm = new itemMaster(this);
            itemFrm.MdiParent = this;

            if (itemMaster.lodd == 0)
            {
                itemFrm.Show();
                return;
            }
            else
            {
                itemFrm.BringToFront();
                return;

            }
        }

        private void sUPPLIERMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier supForm = new supplier();
            supForm.MdiParent = this;
            if (supplier.lodd == 0)
            {
                supForm.Show();
                return;
            }
            else
            {
                supForm.BringToFront();
                return;

            }
        }

        private void sALESREPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesRep salRep = new frmSalesRep();
            salRep.MdiParent = this;
            if (frmSalesRep.lodd == 0)
            {
                salRep.Show();
                return;
            }
            else
            {
                salRep.BringToFront();
                return;

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean val = MessageBox.Show("Are you sure you want to Logout this System?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (val)
            {
                this.Dispose();
                loginForm.Show();
                
            }
            else
            {

            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

         if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice itemFrm = new frmInvoice();
            itemFrm.Show();
            //itemFrm.MdiParent = this;

            //if (frmInvoice.lodd == 0)
            //{
            //    itemFrm.Show();
            //    return;
            //}
            //else
            //{
            //    itemFrm.BringToFront();
            //    return;

            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = dateTime.ToLongDateString();
            lblTime.Text = dateTime.ToLongTimeString();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompanyInfo supForm = new frmCompanyInfo();
            supForm.MdiParent = this;
            if (frmCompanyInfo.lodd == 0)
            {
                supForm.Show();
                return;
            }
            else
            {
                supForm.BringToFront();
                return;

            }
        }

        public static string location = "HO";//{ get; set; }
    }
}
