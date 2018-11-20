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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.SimGUI
{
    public partial class SimGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        public SimGUI()
        {
            InitializeComponent();
            
        }
        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = sim.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã sim";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Số điện thoại";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Tình trạng";
            ((GridView)gridControl.MainView).Columns[3].Visible = false;
            ((GridView)gridControl.MainView).Columns[4].Visible = false;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            SimCreateInfoGUI sim_create = new SimCreateInfoGUI();
            sim_create.Visible = true;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SimEditGUI sim_edit = new SimEditGUI();
            sim_edit.Visible = true; 
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            sim.Delete(Convert.ToInt32(gridView.GetFocusedRowCellValue("ID_SIM")));
            gridControl.DataSource = sim.GetAll();
        }
    }
}