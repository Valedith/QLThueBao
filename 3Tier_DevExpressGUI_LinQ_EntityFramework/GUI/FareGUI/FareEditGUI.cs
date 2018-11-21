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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.FareGUI
{
    public partial class FareEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FareBUS fare = new FareBUS();
        SimBUS sim = new SimBUS();
        public FareEditGUI()
        {
            InitializeComponent();
            cb_sim_Load();
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = fare.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã thuế cước";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Thời gian bắt đầu trước 7h";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Thời gian bắt đầu sau 7h";
            ((GridView)gridControl1.MainView).Columns[4].Caption = "Thời gian kết thúc trước 23h";
            ((GridView)gridControl1.MainView).Columns[5].Caption = "Thời gian kết thúc sau 23h";
            ((GridView)gridControl1.MainView).Columns[6].Visible = false;
            Reset();
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
        private void Reset()
        {
            txt_id.Text = "";time_starta7.EditValue = 0; time_startb7.EditValue = 0; time_stopa23.EditValue = 0; time_stopb23.EditValue = 0;
            cb_sim.SelectedItem = null;
            cb_sim.SelectedText = "Mã sim | Số điện thoại | Tình trạng";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            cb_sim.SelectedValue = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            time_starta7.EditValue = gridView1.GetFocusedRowCellValue("TIME_STARTA7");
            time_startb7.EditValue = gridView1.GetFocusedRowCellValue("TIME_STARTB7");
            time_stopa23.EditValue = gridView1.GetFocusedRowCellValue("TIME_STOPA23");
            time_stopb23.EditValue = gridView1.GetFocusedRowCellValue("TIME_STOPB23");
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fare.Update(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_startb7.EditValue.ToString()), TimeSpan.Parse(time_starta7.EditValue.ToString()), TimeSpan.Parse(time_stopa23.EditValue.ToString()), TimeSpan.Parse(time_stopb23.EditValue.ToString()));
            gridControl1.DataSource = fare.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fare.Update(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_startb7.EditValue.ToString()), TimeSpan.Parse(time_starta7.EditValue.ToString()), TimeSpan.Parse(time_stopa23.EditValue.ToString()), TimeSpan.Parse(time_stopb23.EditValue.ToString()));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fare.Update(Convert.ToInt32(txt_id.Text), Convert.ToInt32(cb_sim.SelectedValue), TimeSpan.Parse(time_startb7.EditValue.ToString()), TimeSpan.Parse(time_starta7.EditValue.ToString()), TimeSpan.Parse(time_stopa23.EditValue.ToString()), TimeSpan.Parse(time_stopb23.EditValue.ToString()));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fare.Delete(Convert.ToInt32(txt_id.Text));
            gridControl1.DataSource = fare.GetAll();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}