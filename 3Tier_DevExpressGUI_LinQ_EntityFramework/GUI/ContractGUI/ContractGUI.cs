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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.ContractGUI
{
    public partial class CustomerCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ContractBUS contract = new ContractBUS();
        public CustomerCreateInfoGUI()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = contract.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã hợp đồng";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Ngày đăng ký";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Phí đăng ký";
            ((GridView)gridControl.MainView).Columns[4].Visible = false;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContractCreateInfoGUI contr_create = new ContractCreateInfoGUI();
            contr_create.Visible = true;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContractEditGUI contr_edit = new ContractEditGUI();
            contr_edit.Visible = true;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetFocusedRowCellValue("ID_CONTRACT") == null)
                MessageBox.Show("Hãy chọn dữ liệu để xóa !");
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này ?",
                                            "Xác nhận xóa dữ liệu",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    contract.Delete(gridView.GetFocusedRowCellValue("ID_CONTRACT").ToString());
                    gridControl.DataSource = contract.GetAll();
                }
            }
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

        private void btn_close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btn_Refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = contract.GetAll();
        }
    }
}