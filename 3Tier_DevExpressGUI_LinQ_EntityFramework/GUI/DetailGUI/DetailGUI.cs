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
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.DetailGUI
{
    public partial class DetailGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DetailBUS detail = new DetailBUS();
        public DetailGUI()
        {
            InitializeComponent();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetailEditGUI edit = new DetailEditGUI();
            edit.Visible = true;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetailCreateInfoGUI detail_Create = new DetailCreateInfoGUI();
            detail_Create.Visible = true;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            detail.Delete(Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")));
            gridControl.DataSource = detail.GetAll();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = detail.GetAll();
        }

        private void btn_Import_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetailImportGUI import = new DetailImportGUI();
            import.Visible = true;
        }

        private void btn_backtoMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainGUI main = new MainGUI();
            main.Show();
            this.Hide();
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = detail.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã hóa đơn chi tiết";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Thời gian bắt đầu";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Thời gian kết thúc";
            ((GridView)gridControl.MainView).Columns[4].Caption = "Số phút sử dụng từ sau 7h đến 23h trong ngày";
            ((GridView)gridControl.MainView).Columns[5].Caption = "Số phút sử dụng từ sau 23h đến 7h hôm sau";
            ((GridView)gridControl.MainView).Columns[6].Caption = "Cước phí sử dụng";
            ((GridView)gridControl.MainView).Columns[7].Visible = false;
        }
    }
}