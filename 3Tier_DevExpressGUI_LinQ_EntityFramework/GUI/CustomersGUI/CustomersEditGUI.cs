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
using DevExpress.XtraGrid.Views.Grid;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.CustomersGUI
{
    public partial class CustomersEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerBUS customer = new CustomerBUS();
        public CustomersEditGUI()
        {
            InitializeComponent();
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = customer.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã khách hàng";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Tên khách hàng";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Số CMND";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Nghề nghiệp";
            ((GridView)gridControl1.MainView).Columns[4].Caption = "Chức vụ";
            ((GridView)gridControl1.MainView).Columns[5].Caption = "Địa chỉ";
            ((GridView)gridControl1.MainView).Columns[6].Visible = false;
            ((GridView)gridControl1.MainView).Columns[7].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
            txt_name.Text = gridView1.GetFocusedRowCellValue("NAME").ToString();
            txt_iden.Text = gridView1.GetFocusedRowCellValue("IDENTIFY").ToString();
            txt_job.Text = gridView1.GetFocusedRowCellValue("JOB").ToString();
            txt_position.Text = gridView1.GetFocusedRowCellValue("POSITION").ToString();
            txt_address.Text = gridView1.GetFocusedRowCellValue("ADDRESS").ToString();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Update(txt_id.Text,txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text,txt_position.Text,txt_address.Text);
            gridControl1.DataSource = customer.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Update(txt_id.Text, txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text);
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Update(txt_id.Text, txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text);
            txt_id.Text = "";txt_name.Text = "";txt_job.Text = "";txt_position.Text = "";txt_address.Text = "";txt_iden.Text = "";
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_id.Text = ""; txt_name.Text = ""; txt_job.Text = ""; txt_position.Text = ""; txt_address.Text = ""; txt_iden.Text = "";
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Delete(txt_name.Text);
            gridControl1.DataSource = customer.GetAll();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}