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
        public SimCreateInfoGUI()
        {
            InitializeComponent();
            cb_status_Load();
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
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
                MessageBox.Show(sim.Create(Convert.ToInt32(txt_phone.Text), 0));
            else
                MessageBox.Show(sim.Create(Convert.ToInt32(txt_phone.Text), 1));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                MessageBox.Show(sim.Create(Convert.ToInt32(txt_phone.Text), 0));
                this.Dispose();
            }
            else
            {
                MessageBox.Show(sim.Create(Convert.ToInt32(txt_phone.Text), 1));
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
                MessageBox.Show(sim.Create(Convert.ToInt32(txt_phone.Text), 0));
                Reset();
            }
            else
            {
                MessageBox.Show(sim.Create(Convert.ToInt32(txt_phone.Text), 1));
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