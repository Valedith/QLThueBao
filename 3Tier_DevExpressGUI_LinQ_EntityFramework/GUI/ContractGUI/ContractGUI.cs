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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.ContractGUI
{
    public partial class ContractGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ContractBUS contract = new ContractBUS();
        public ContractGUI()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = contract.GetAll();
            gridControl.MainView.PopulateColumns();
            ((GridView)gridControl.MainView).Columns[0].Caption = "Mã hợp đồng";
            ((GridView)gridControl.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)gridControl.MainView).Columns[2].Caption = "Mã Sim";
            ((GridView)gridControl.MainView).Columns[3].Caption = "Ngày đăng ký";
            ((GridView)gridControl.MainView).Columns[4].Caption = "Thuế hàng tháng";
            ((GridView)gridControl.MainView).Columns[5].Visible = false;
            ((GridView)gridControl.MainView).Columns[6].Visible = false;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContractCreateInfoGUI contr_create = new ContractCreateInfoGUI();
            contr_create.Visible = true;
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContractEditGUI contr_edit = new ContractEditGUI();
            contr_edit.Visible = true;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            contract.Delete(gridView.GetFocusedRowCellValue("ID_CONTRACT").ToString());
            gridControl.DataSource = contract.GetAll();
        }
        
    }
}