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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.DetailGUI
{
    public partial class DetailEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        DetailBUS detail = new DetailBUS();
        public DetailEditGUI()
        {
            InitializeComponent();
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            dtp_stop.Format = DateTimePickerFormat.Custom;
            dtp_stop.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            cb_sim_Load();
        }
        private void cb_sim_Load()
        {
            cb_Sim.DataSource = sim.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} |", row.ID_SIM, row.PHONENUMBER, row.STATUS),
                Value = row.ID_SIM
            }).ToList();

            cb_Sim.DisplayMember = "Text";
            cb_Sim.ValueMember = "Value";

            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã sim | Số điện thoại | Tình trạng";

        }
        private void Reset()
        {
            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã sim | Số điện thoại | Tình trạng";

            txt_ID.Text = ""; dtp_start.Value = DateTime.Now; dtp_stop.Value = DateTime.Now;
            txt_MinA7.Text = "";txt_MinA23.Text = "";txt_Fare.Text = "";
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(detail.Update(Convert.ToInt32(txt_ID.Text), cb_Sim.SelectedValue.ToString(), dtp_start.Value, dtp_stop.Value));
            gridControl1.DataSource = detail.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(detail.Update(Convert.ToInt32(txt_ID.Text), cb_Sim.SelectedValue.ToString(), dtp_start.Value, dtp_stop.Value));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(detail.Update(Convert.ToInt32(txt_ID.Text), cb_Sim.SelectedValue.ToString(), dtp_start.Value, dtp_stop.Value));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_ID.Text == "")
                MessageBox.Show("Hãy chọn dữ liệu để xóa !");
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này ?",
                                            "Xác nhận xóa dữ liệu",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(detail.Delete(Convert.ToInt32(txt_ID.Text)));
                    gridControl1.DataSource = detail.GetAll();
                    Reset();
                }
            }
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

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = detail.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã hóa đơn chi tiết";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Thời gian bắt đầu";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Thời gian kết thúc";
            ((GridView)gridControl1.MainView).Columns[4].Caption = "Số phút sử dụng từ sau 7h đến 23h trong ngày";
            ((GridView)gridControl1.MainView).Columns[5].Caption = "Số phút sử dụng từ sau 23h đến 7h hôm sau";
            ((GridView)gridControl1.MainView).Columns[6].Caption = "Cước phí sử dụng";
            ((GridView)gridControl1.MainView).Columns[7].Visible = false;
            Reset();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_ID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            cb_Sim.SelectedValue = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            dtp_start.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("TIME_START").ToString());
            dtp_stop.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("TIME_STOP").ToString());
            txt_MinA7.Text = gridView1.GetFocusedRowCellValue("MINUTE_AFTER7").ToString();
            txt_MinA23.Text = gridView1.GetFocusedRowCellValue("MINUTE_AFTER23").ToString();
            txt_Fare.Text = gridView1.GetFocusedRowCellValue("FATE").ToString();
        }
    }
}