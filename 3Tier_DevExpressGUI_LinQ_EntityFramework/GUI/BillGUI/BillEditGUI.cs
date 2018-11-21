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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.BillGUI
{
    public partial class BillEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BillBUS bill = new BillBUS();
        CustomerBUS customer = new CustomerBUS();
        public BillEditGUI()
        {
            InitializeComponent();
            date_Export.CustomFormat = "dd-MM-yyyy";
            cb_CusId_Load();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(num_Minutes.Value), date_Export.Value,date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text));
            gridControl1.DataSource = bill.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(num_Minutes.Value), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(num_Minutes.Value), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text));
            Reset();
        }
        private void cb_CusId_Load()
        {
            cb_CusId.DataSource = customer.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} | {3,5} | {4,5}  ", row.ID_CUSTOMER, row.NAME, row.IDENTIFY, row.POSITION, row.ADDRESS),
                Value = row.ID_CUSTOMER
            }).ToList();

            cb_CusId.DisplayMember = "Text";
            cb_CusId.ValueMember = "Value";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_BILL").ToString();
            cb_CusId.SelectedValue = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
            num_Minutes.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("USE_MINUTE").ToString());
            num_Postage.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("POSTAGE").ToString());
            txt_fare.Text = gridView1.GetFocusedRowCellValue("FARE").ToString();
            date_Export.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("DATE_EXPORT").ToString());
            txt_datecut.Text = gridView1.GetFocusedRowCellValue("DATE_CUT").ToString();
        }
        private void Reset()
        {
            cb_CusId.SelectedItem = null;
            cb_CusId.SelectedText = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";

            txt_id.Text = ""; num_Minutes.Value = 0; num_Postage.Value = 50000;txt_fare.Text = "";date_Export.Value = DateTime.Now;txt_datecut.Text = "";
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = bill.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã hóa đơn";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Số phút sử dụng";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Ngày xuất phiếu";
            ((GridView)gridControl1.MainView).Columns[4].Caption = "Ngày cắt";
            ((GridView)gridControl1.MainView).Columns[5].Caption = "Cước thuê bao";
            ((GridView)gridControl1.MainView).Columns[6].Caption = "Cước tháng";
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
    }
}