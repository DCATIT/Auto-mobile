using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AUTOPARTS.DCAT.BL;
using AUTOPARTS.DCAT.BL.MASTERS;


namespace AUTOPARTS.DCAT.UI.MASTERS
{
    public partial class frmScrItemMaster : Form
    {

        MainWindow mainwindow;
        UI.MASTERS.itemMaster ui_itemmaster;
        BL_ItemMaster bl_itemmaster = new BL_ItemMaster();


        public frmScrItemMaster(MainWindow mw,itemMaster im)
        {
            InitializeComponent();
            mainwindow = mw;
            ui_itemmaster = im;
        }

        private void frmItemMaster_Search_Load(object sender, EventArgs e)
        {
            this.Parent = mainwindow;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bl_itemmaster.SetSearchData(dgv,txtItmCode,txtIdesc,txtPtNo,txtPartName,txtAltPtNo,txtAltPtName);
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                string code = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                ui_itemmaster.SetSearchedID(code);
                this.Close(); 
            }
        }


    }
}
