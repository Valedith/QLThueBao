using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.FareGUI
{
    public partial class FareGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FareBUS fare = new FareBUS();
        public FareGUI()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = fare.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã thuế cước";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Thời gian bắt đầu trước 7h";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Thời gian bắt đầu sau 7h";
            ((GridView)gridControl.MainView).Columns[4].Caption = "Thời gian kết thúc trước 23h";
            ((GridView)gridControl.MainView).Columns[5].Caption = "Thời gian kết thúc sau 23h";
            ((GridView)gridControl.MainView).Columns[6].Visible = false;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            FareCreateInfoGUI fare_create = new FareCreateInfoGUI();
            fare_create.Visible = true;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            FareEditGUI fare_edit = new FareEditGUI();
            fare_edit.Visible = true;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            fare.Delete(Convert.ToInt32(gridView.GetFocusedRowCellValue("ID").ToString()));
            gridControl.DataSource = fare.GetAll();
        }

        private void btn_Import_ItemClick(object sender, ItemClickEventArgs e)
        {
            FareImportGUI fareimport = new FareImportGUI();
            fareimport.Visible = true;
        }
    }
}