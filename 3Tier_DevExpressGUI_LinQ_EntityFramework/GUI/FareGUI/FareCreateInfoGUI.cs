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
            fare.Create(Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_startb7.EditValue.ToString()), TimeSpan.Parse(time_starta7.EditValue.ToString()), TimeSpan.Parse(time_stopa23.EditValue.ToString()), TimeSpan.Parse(time_stopb23.EditValue.ToString()));

        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fare.Create(Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_startb7.EditValue.ToString()), TimeSpan.Parse(time_starta7.EditValue.ToString()), TimeSpan.Parse(time_stopa23.EditValue.ToString()), TimeSpan.Parse(time_stopb23.EditValue.ToString()));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fare.Create(Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_startb7.EditValue.ToString()), TimeSpan.Parse(time_starta7.EditValue.ToString()), TimeSpan.Parse(time_stopa23.EditValue.ToString()), TimeSpan.Parse(time_stopb23.EditValue.ToString()));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            time_starta7.EditValue = 0; time_startb7.EditValue = 0; time_stopa23.EditValue = 0; time_stopb23.EditValue = 0;
            cb_sim.SelectedItem = null;
            cb_sim.SelectedText = "Mã sim | Số điện thoại | Tình trạng";
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
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}