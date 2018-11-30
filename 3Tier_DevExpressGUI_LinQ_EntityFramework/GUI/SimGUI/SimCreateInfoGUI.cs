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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.SimGUI
{
    public partial class SimCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        CustomerBUS customer = new CustomerBUS();
        public SimCreateInfoGUI()
        {
            InitializeComponent();
            cb_status_Load();
            cb_customer_Load();
        }
        private void cb_customer_Load()
        {
            cb_CusId.DataSource = customer.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} | {3,5} | {4,5}  ", row.ID_CUSTOMER, row.NAME, row.IDENTIFY, row.POSITION, row.ADDRESS),
                Value = row.ID_CUSTOMER
            }).ToList();

            cb_CusId.DisplayMember = "Text";
            cb_CusId.ValueMember = "Value";

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
        }
        private void cb_status_Load()
        {
            cb_status.SelectedItem = null;
            cb_status.Text = "Hãy chọn tình trạng Sim";
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
        private void Reset()
        {
            txt_phone.Text = "";
            cb_status.SelectedItem = null;
            cb_status.Text = "Hãy chọn tình trạng Sim";

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
                MessageBox.Show(sim.Create(cb_CusId.SelectedValue.ToString(),Convert.ToInt32(txt_phone.Text), false));
            else
                MessageBox.Show(sim.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), true));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                MessageBox.Show(sim.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), false));
                this.Dispose();
            }
            else
            {
                MessageBox.Show(sim.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), true));
                this.Dispose();
            }

        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                MessageBox.Show(sim.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), false));
                Reset();
            }
            else
            {
                MessageBox.Show(sim.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), true));
                Reset();
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
    }
}