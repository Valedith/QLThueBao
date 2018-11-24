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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.CustomersGUI
{
    public partial class CustomersGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerBUS customer = new CustomerBUS();
        public CustomersGUI()
        {
            InitializeComponent();
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = customer.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã khách hàng";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Tên khách hàng";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Số CMND";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Nghề nghiệp";
            ((GridView)gridControl.MainView).Columns[4].Caption = "Chức vụ";
            ((GridView)gridControl.MainView).Columns[5].Caption = "Địa chỉ";
            ((GridView)gridControl.MainView).Columns[6].Visible = false;
            ((GridView)gridControl.MainView).Columns[7].Visible = false;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetFocusedRowCellValue("ID_CUSTOMER") == null)
                MessageBox.Show("Hãy chọn dữ liệu để xóa !");
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này ?",
                                            "Xác nhận xóa dữ liệu",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    customer.Delete(gridView.GetFocusedRowCellValue("ID_CUSTOMER").ToString());
                    gridControl.DataSource = customer.GetAll();
                }
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomersEditGUI cus_edit = new CustomersEditGUI();
            cus_edit.Visible = true; 
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomersCreateInfoGUI cus_create = new CustomersCreateInfoGUI();
            cus_create.Visible = true;
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
            gridControl.DataSource = customer.GetAll();
        }
    }
}