using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.BillGUI
{
    public partial class BillGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BillBUS bill = new BillBUS();
        public BillGUI()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            BillCreateInfoGUI bill_create = new BillCreateInfoGUI();
            bill_create.Visible = true;
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = bill.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã hóa đơn";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Số phút sử dụng";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Ngày xuất phiếu";
            ((GridView)gridControl.MainView).Columns[4].Caption = "Ngày cắt";
            ((GridView)gridControl.MainView).Columns[5].Caption = "Cước thuê bao";
            ((GridView)gridControl.MainView).Columns[6].Caption = "Cước tháng";
            ((GridView)gridControl.MainView).Columns[7].Visible = false;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            BillEditGUI bill_edit = new BillEditGUI();
            bill_edit.Visible = true;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            bill.Delete(gridView.GetFocusedRowCellValue("ID_BILL").ToString());
            gridControl.DataSource = bill.GetAll();
        }

        private void btn_backtoMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainGUI main = new MainGUI();
            main.Show();
            this.Hide();
        }

        private void btn_logOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btn_Refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = bill.GetAll();
        }
    }
}