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
using DevExpress.XtraBars;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.BillGUI
{
    public partial class BillCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BillBUS bill = new BillBUS();
        SimBUS sim = new SimBUS();
        public BillCreateInfoGUI()
        {
            InitializeComponent();
            date_Export.CustomFormat = "dd-MM-yyyy";
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
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                bill.Create(cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
            }
            else
            {
                bill.Create(cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), true);
            }
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                bill.Create(cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                this.Dispose();
            }
            else
            {
                bill.Create(cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), true);
                this.Dispose();
            }
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                bill.Create(cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), false);
                Reset();
            }
            else
            {
                bill.Create(cb_Sim.SelectedValue.ToString(), date_Export.Value, date_Export.Value.AddDays(30), Convert.ToInt32(num_Postage.Value), Convert.ToInt32(txt_fare.Text), true);
                Reset();
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";

            cb_status.SelectedItem = null;
            cb_status.Text = "Hãy chọn tình trạng thanh toán hóa đơn";
            num_Postage.Value = 50000; txt_fare.Text = ""; date_Export.Value = DateTime.Now; txt_datecut.Text = "";
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
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