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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.BillGUI
{
    public partial class BillCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BillBUS bill = new BillBUS();
        CustomerBUS customer = new CustomerBUS();
        public BillCreateInfoGUI()
        {
            InitializeComponent();
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
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(num_Minutes.Value), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(num_Minutes.Value), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bill.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(num_Minutes.Value), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cb_CusId.SelectedItem = null;
            cb_CusId.SelectedText = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";

            num_Minutes.Value = 0; num_Postage.Value = 50000; txt_fare.Text = ""; date_Export.Value = DateTime.Now; txt_datecut.Text = "";
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}