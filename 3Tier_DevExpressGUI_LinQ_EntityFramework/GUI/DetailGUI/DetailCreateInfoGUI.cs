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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.DetailGUI
{
    public partial class DetailCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        DetailBUS detail = new DetailBUS();
        public DetailCreateInfoGUI()
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
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(detail.Create(cb_Sim.SelectedValue.ToString(), dtp_start.Value, dtp_stop.Value));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(detail.Create(cb_Sim.SelectedValue.ToString(), dtp_start.Value, dtp_stop.Value));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(detail.Create(cb_Sim.SelectedValue.ToString(), dtp_start.Value, dtp_stop.Value));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cb_Sim.SelectedItem = null;
            cb_Sim.Text = "Mã sim | Số điện thoại | Tình trạng";

            dtp_start.Value = DateTime.Now; dtp_stop.Value = DateTime.Now;
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

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}