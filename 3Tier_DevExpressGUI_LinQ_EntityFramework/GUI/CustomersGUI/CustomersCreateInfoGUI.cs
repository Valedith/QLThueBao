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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.CustomersGUI
{
    public partial class CustomersCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerBUS customer = new CustomerBUS();
        public CustomersCreateInfoGUI()
        {
            InitializeComponent();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("Vui lòng nhập họ tên khách hàng !");
            else if (txt_job.Text == "")
                MessageBox.Show("Vui lòng nhập nghề nghiệp khách hàng !");
            else if (txt_position.Text == "")
                MessageBox.Show("Vui lòng nhập chức vụ khách hàng !");
            else if (txt_address.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng !");
            else
            MessageBox.Show(customer.Create(txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text).ToString());
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("Vui lòng nhập họ tên khách hàng !");
            else if (txt_job.Text == "")
                MessageBox.Show("Vui lòng nhập nghề nghiệp khách hàng !");
            else if (txt_position.Text == "")
                MessageBox.Show("Vui lòng nhập chức vụ khách hàng !");
            else if (txt_address.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng !");
            else
                MessageBox.Show(customer.Create(txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text).ToString());
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("Vui lòng nhập họ tên khách hàng !");
            else if (txt_job.Text == "")
                MessageBox.Show("Vui lòng nhập nghề nghiệp khách hàng !");
            else if (txt_position.Text == "")
                MessageBox.Show("Vui lòng nhập chức vụ khách hàng !");
            else if (txt_address.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng !");
            else
                MessageBox.Show(customer.Create(txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text).ToString());
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txt_name.Text = ""; txt_job.Text = ""; txt_position.Text = ""; txt_address.Text = ""; txt_iden.Text = "";
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

        private void txt_iden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}