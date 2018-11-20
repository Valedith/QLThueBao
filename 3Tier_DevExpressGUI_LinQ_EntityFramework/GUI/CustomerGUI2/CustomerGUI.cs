using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.CustomerGUI
{
    public partial class Customer1GUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerBUS customer = new CustomerBUS();
        public Customer1GUI()
        {
            InitializeComponent();
        }

        private void gridControl_Customer_Load(object sender, EventArgs e)
        {
            gridControl_Customer.DataSource = customer.GetAll();
            gridControl_Customer.MainView.PopulateColumns();
            ((GridView)gridControl_Customer.MainView).Columns[0].Caption = "Mã khách hàng";
            ((GridView)gridControl_Customer.MainView).Columns[1].Caption = "Tên khách hàng";
            ((GridView)gridControl_Customer.MainView).Columns[2].Caption = "Số CMND";
            ((GridView)gridControl_Customer.MainView).Columns[3].Caption = "Nghề nghiệp";
            ((GridView)gridControl_Customer.MainView).Columns[4].Caption = "Chức vụ";
            ((GridView)gridControl_Customer.MainView).Columns[5].Caption = "Địa chỉ";
            ((GridView)gridControl_Customer.MainView).Columns[6].Visible = false;
            ((GridView)gridControl_Customer.MainView).Columns[7].Visible = false;
            Clear();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            customer.Create(txt_name.Text,Convert.ToInt32(txt_identity.Text),txt_job.Text,txt_position.Text,txt_address.Text);

            gridControl_Customer.DataSource = customer.GetAll();
        }
        private void Clear()
        {
            txt_ID.Text = txt_name.Text = txt_identity.Text = txt_job.Text = txt_position.Text = txt_address.Text = "";
        }
        
        private void gridView_Customer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_ID.Text = gridView_Customer.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
            txt_name.Text = gridView_Customer.GetFocusedRowCellValue("NAME").ToString();
            txt_identity.Text = gridView_Customer.GetFocusedRowCellValue("IDENTIFY").ToString();
            txt_job.Text = gridView_Customer.GetFocusedRowCellValue("JOB").ToString();
            txt_position.Text = gridView_Customer.GetFocusedRowCellValue("POSITION").ToString();
            txt_address.Text = gridView_Customer.GetFocusedRowCellValue("ADDRESS").ToString();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            customer.Update(txt_ID.Text,txt_name.Text, Convert.ToInt32(txt_identity.Text), txt_job.Text,txt_position.Text,txt_address.Text);

            gridControl_Customer.DataSource = customer.GetAll();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            customer.Delete(txt_ID.Text);

            gridControl_Customer.DataSource = customer.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customer.SearchByName(txt_Search.Text) != null)
                gridControl_Customer.DataSource = customer.SearchByName(txt_Search.Text);
            else
                MessageBox.Show("String not found");
        }
    }
}