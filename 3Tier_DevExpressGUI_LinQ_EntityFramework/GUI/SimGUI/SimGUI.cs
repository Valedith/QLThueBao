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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.SimGUI
{
    public partial class SimGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        public SimGUI()
        {
            InitializeComponent(); 

        }
        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = sim.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã sim";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Số điện thoại";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Tình trạng";
            ((GridView)gridControl.MainView).Columns[4].Visible = false;
            ((GridView)gridControl.MainView).Columns[5].Visible = false;
            ((GridView)gridControl.MainView).Columns[6].Visible = false;
            ((GridView)gridControl.MainView).Columns[7].Visible = false;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SimCreateInfoGUI sim_create = new SimCreateInfoGUI();
            sim_create.Visible = true;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SimEditGUI sim_edit = new SimEditGUI();
            sim_edit.Visible = true; 
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetFocusedRowCellValue("ID_SIM") == null)
                MessageBox.Show("Hãy chọn dữ liệu để xóa !");
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này ?",
                                            "Xác nhận xóa dữ liệu",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(sim.Delete(gridView.GetFocusedRowCellValue("ID_SIM").ToString()));
                    gridControl.DataSource = sim.GetAll();
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

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.DataSource = sim.GetAll();
        }
    }
}