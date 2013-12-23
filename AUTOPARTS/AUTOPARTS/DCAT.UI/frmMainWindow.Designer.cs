namespace AUTOPARTS
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mASTERFILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEPARTMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBDEPARTMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBCATEGORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERMASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESREPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTERFILESToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mASTERFILESToolStripMenuItem
            // 
            this.mASTERFILESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dEPARTMENTToolStripMenuItem,
            this.sUBDEPARTMENTToolStripMenuItem,
            this.cATEGORYToolStripMenuItem,
            this.sUBCATEGORYToolStripMenuItem,
            this.iTEMMASTERToolStripMenuItem,
            this.sUPPLIERMASTERToolStripMenuItem,
            this.sALESREPToolStripMenuItem});
            this.mASTERFILESToolStripMenuItem.Name = "mASTERFILESToolStripMenuItem";
            this.mASTERFILESToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.mASTERFILESToolStripMenuItem.Text = "Masters";
            // 
            // dEPARTMENTToolStripMenuItem
            // 
            this.dEPARTMENTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dEPARTMENTToolStripMenuItem.Name = "dEPARTMENTToolStripMenuItem";
            this.dEPARTMENTToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dEPARTMENTToolStripMenuItem.Text = "Department";
            this.dEPARTMENTToolStripMenuItem.Click += new System.EventHandler(this.dEPARTMENTToolStripMenuItem_Click);
            // 
            // sUBDEPARTMENTToolStripMenuItem
            // 
            this.sUBDEPARTMENTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUBDEPARTMENTToolStripMenuItem.Name = "sUBDEPARTMENTToolStripMenuItem";
            this.sUBDEPARTMENTToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sUBDEPARTMENTToolStripMenuItem.Text = "Sub Department";
            this.sUBDEPARTMENTToolStripMenuItem.Click += new System.EventHandler(this.sUBDEPARTMENTToolStripMenuItem_Click);
            // 
            // cATEGORYToolStripMenuItem
            // 
            this.cATEGORYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cATEGORYToolStripMenuItem.Name = "cATEGORYToolStripMenuItem";
            this.cATEGORYToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cATEGORYToolStripMenuItem.Text = "Category";
            this.cATEGORYToolStripMenuItem.Click += new System.EventHandler(this.cATEGORYToolStripMenuItem_Click);
            // 
            // sUBCATEGORYToolStripMenuItem
            // 
            this.sUBCATEGORYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUBCATEGORYToolStripMenuItem.Name = "sUBCATEGORYToolStripMenuItem";
            this.sUBCATEGORYToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sUBCATEGORYToolStripMenuItem.Text = "Sub Category";
            this.sUBCATEGORYToolStripMenuItem.Click += new System.EventHandler(this.sUBCATEGORYToolStripMenuItem_Click);
            // 
            // iTEMMASTERToolStripMenuItem
            // 
            this.iTEMMASTERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTEMMASTERToolStripMenuItem.Name = "iTEMMASTERToolStripMenuItem";
            this.iTEMMASTERToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.iTEMMASTERToolStripMenuItem.Text = "Parts List";
            this.iTEMMASTERToolStripMenuItem.Click += new System.EventHandler(this.iTEMMASTERToolStripMenuItem_Click);
            // 
            // sUPPLIERMASTERToolStripMenuItem
            // 
            this.sUPPLIERMASTERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUPPLIERMASTERToolStripMenuItem.Name = "sUPPLIERMASTERToolStripMenuItem";
            this.sUPPLIERMASTERToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sUPPLIERMASTERToolStripMenuItem.Text = "Supplier";
            this.sUPPLIERMASTERToolStripMenuItem.Click += new System.EventHandler(this.sUPPLIERMASTERToolStripMenuItem_Click);
            // 
            // sALESREPToolStripMenuItem
            // 
            this.sALESREPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sALESREPToolStripMenuItem.Name = "sALESREPToolStripMenuItem";
            this.sALESREPToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sALESREPToolStripMenuItem.Text = "Sales Rep";
            this.sALESREPToolStripMenuItem.Click += new System.EventHandler(this.sALESREPToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.lockToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 21);
            this.toolStripMenuItem1.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.companyToolStripMenuItem.Text = "Company Info";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 30);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(621, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.lblDate.Size = new System.Drawing.Size(46, 26);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(667, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.lblTime.Size = new System.Drawing.Size(45, 26);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 26);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyrights © DCAT IT Solutions All Rights Reserved";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(714, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.Text = "AUTO MOBILE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mASTERFILESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEPARTMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBDEPARTMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBCATEGORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMMASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERMASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALESREPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

