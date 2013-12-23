using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.DAL;
using AUTOPARTS.DCAT.BL;
using AUTOPARTS.DCAT.MODELS;

namespace AUTOPARTS.DCAT.LOGIN
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Some validation Method
            string un = txtUN.Text;
            string PW = txtPW.Text;
            
            Model_User usr = new Model_User();
            usr.UNAME = un;
            usr.UPW = PW;

            int expVal = BL_UserLogin.CHECKUSER(usr);

            //If validation is true
            Form mw = new MainWindow(this);
            mw.Show();
            this.Hide();
        }
        //protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        //{
        //    System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
        //    shape.AddEllipse(0,0, this.Width, this.Height);
        //    this.Region = new System.Drawing.Region(shape);
        //}
    }
}
