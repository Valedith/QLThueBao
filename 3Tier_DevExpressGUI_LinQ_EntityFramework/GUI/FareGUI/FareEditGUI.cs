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
using DevExpress.XtraBars;
using System.Globalization;
using DevExpress.XtraEditors.Mask;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.FareGUI
{
    public partial class FareEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FareBUS fare = new FareBUS();
        SimBUS sim = new SimBUS();
        public FareEditGUI()
        {
            InitializeComponent();
            time_start.Properties.Mask.MaskType = time_stop.Properties.Mask.MaskType = MaskType.DateTime;
            time_start.Properties.Mask.EditMask = time_stop.Properties.Mask.EditMask = "HH:mm:ss";
            time_start.MaskBox.Mask.UseMaskAsDisplayFormat = time_stop.MaskBox.Mask.UseMaskAsDisplayFormat = true;
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = fare.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã thuế cước";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Thời gian bắt đầu";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Thời gian kết thúc";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Giá cước";
            Reset();
        }
        private void Reset()
        {
            txt_id.Text = "";num_fare.Value = 0;
            
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_FARE").ToString();
            num_fare.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FARE1").ToString());
            time_start.EditValue = gridView1.GetFocusedRowCellValue("TIME_START").ToString();
            time_stop.EditValue = gridView1.GetFocusedRowCellValue("TIME_STOP").ToString();
            txt_time2start.Text = time_stop.EditValue.ToString();
            txt_time2stop.Text = time_start.EditValue.ToString();

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(fare.Update(txt_id.Text, Convert.ToInt32(num_fare.Value), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString())));
            if (txt_id.Text == "DAY")
                fare.Update_rest("NIGHT", TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()));
            else
                fare.Update_rest("DAY", TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()));
            gridControl1.DataSource = fare.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(fare.Update(txt_id.Text, Convert.ToInt32(num_fare.Value), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString())));
            if (txt_id.Text == "DAY")
                fare.Update_rest("NIGHT", TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()));
            else
                fare.Update_rest("DAY", TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(fare.Update(txt_id.Text, Convert.ToInt32(num_fare.Value), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString())));
            if (txt_id.Text == "DAY")
                fare.Update_rest("NIGHT", TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()));
            else
                fare.Update_rest("DAY", TimeSpan.Parse(time_start.Time.TimeOfDay.ToString()), TimeSpan.Parse(time_stop.Time.TimeOfDay.ToString()));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
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