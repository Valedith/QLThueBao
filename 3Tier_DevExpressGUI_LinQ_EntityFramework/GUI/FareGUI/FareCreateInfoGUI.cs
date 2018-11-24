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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.FareGUI
{
    public partial class FareCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FareBUS fare = new FareBUS();
        SimBUS sim = new SimBUS();
        public FareCreateInfoGUI()
        {
            InitializeComponent();
            cb_sim_Load();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(fare.Create(Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_start.EditValue.ToString()), TimeSpan.Parse(time_stop.EditValue.ToString())));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(fare.Create(Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_start.EditValue.ToString()), TimeSpan.Parse(time_stop.EditValue.ToString())));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(fare.Create(Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_start.EditValue.ToString()), TimeSpan.Parse(time_stop.EditValue.ToString())));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            time_start.EditValue = 0; time_stop.EditValue = 0;
            cb_sim.SelectedItem = null;
            cb_sim.Text = "Mã sim | Số điện thoại | Tình trạng";
        }
        private void cb_sim_Load()
        {
            cb_sim.DataSource = sim.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} |", row.ID_SIM, row.PHONENUMBER, row.STATUS),
                Value = row.ID_SIM
            }).ToList();

            cb_sim.DisplayMember = "Text";
            cb_sim.ValueMember = "Value";

            cb_sim.SelectedItem = null;
            cb_sim.Text = "Mã sim | Số điện thoại | Tình trạng";
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