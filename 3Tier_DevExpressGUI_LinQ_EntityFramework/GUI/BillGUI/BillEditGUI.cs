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
using DevExpress.XtraBars;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.BillGUI
{
    public partial class BillEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BillBUS bill = new BillBUS();
        SimBUS sim = new SimBUS();
        public BillEditGUI()
        {
            InitializeComponent();
            date_Export.CustomFormat = "dd-MM-yyyy";
            cb_sim_Load();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                bill.Update(txt_id.Text, cb_Sim.SelectedValue.ToString(), date_Export.Value,date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text),false);
                gridControl1.DataSource = bill.GetAll();
            }
            else
            {
                bill.Update(txt_id.Text, cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                gridControl1.DataSource = bill.GetAll();
            }
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                bill.Update(txt_id.Text, cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                this.Dispose();
            }
            else
            {
                bill.Update(txt_id.Text, cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                this.Dispose();
            }
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                bill.Update(txt_id.Text, cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                Reset();
            }
            else
            {
                bill.Update(txt_id.Text, cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                Reset();
            }
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
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_BILL").ToString();
            cb_Sim.SelectedValue = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            date_Export.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("DATE_EXPORT").ToString());
            txt_datecut.Text = gridView1.GetFocusedRowCellValue("DATE_CUT").ToString();
            num_Postage.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("POSTAGE").ToString());
            txt_fare.Text = gridView1.GetFocusedRowCellValue("FARE").ToString();
            if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("STATUS")) == 1)
                cb_status.SelectedItem = "Đã thanh toán";
            else
                cb_status.SelectedItem = "Chưa thanh toán";
        }
        private void Reset()
        {
            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";

            cb_status.SelectedItem = null;
            cb_status.Text = "Hãy chọn tình trạng thanh toán hóa đơn";
            txt_id.Text = ""; num_Postage.Value = 50000; txt_fare.Text = "";date_Export.Value = DateTime.Now;txt_datecut.Text = "";
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bill.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã hóa đơn";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Ngày xuất phiếu";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Ngày cắt";
            ((GridView)gridControl1.MainView).Columns[4].Caption = "Cước thuê bao";
            ((GridView)gridControl1.MainView).Columns[5].Caption = "Cước phí hàng tháng";
            ((GridView)gridControl1.MainView).Columns[6].Caption = "Tình trạng";
            ((GridView)gridControl1.MainView).Columns[7].Visible = false;
            Reset();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Delete(txt_id.Text);
            gridControl1.DataSource = bill.GetAll();
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
    }
}