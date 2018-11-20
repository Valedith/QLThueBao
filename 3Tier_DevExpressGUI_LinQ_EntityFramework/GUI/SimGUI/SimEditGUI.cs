using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.SimGUI
{
    public partial class SimEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        public SimEditGUI()
        {
            InitializeComponent();            
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sim.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã sim";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Số điện thoại";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Tình trạng";
            ((GridView)gridControl1.MainView).Columns[3].Visible = false;
            ((GridView)gridControl1.MainView).Columns[4].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            txt_phone.Text = gridView1.GetFocusedRowCellValue("PHONENUMBER").ToString();
            txt_status.Text = gridView1.GetFocusedRowCellValue("STATUS").ToString();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Update(Convert.ToInt32(txt_id.Text),Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_status));
            gridControl1.DataSource = sim.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Update(Convert.ToInt32(txt_id.Text), Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_status));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Update(Convert.ToInt32(txt_id.Text), Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_status));
            txt_id.Text = "";txt_phone.Text = "";txt_status.Text = "";
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_id.Text = ""; txt_phone.Text = ""; txt_status.Text = "";
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Delete(Convert.ToInt32(txt_id.Text));
            gridControl1.DataSource = sim.GetAll();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}