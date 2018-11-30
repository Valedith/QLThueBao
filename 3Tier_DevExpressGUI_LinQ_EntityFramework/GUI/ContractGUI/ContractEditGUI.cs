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
using DevExpress.XtraGrid.Views.Grid;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.ContractGUI
{
    public partial class ContractEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ContractBUS contract = new ContractBUS();
        CustomerBUS customer = new CustomerBUS();
        SimBUS sim = new SimBUS();
        public ContractEditGUI()
        {
            InitializeComponent();
            date_Register.CustomFormat = "dd-MM-yyyy";
            cb_sim_Load();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_CONTRACT").ToString();
            cb_SimId.SelectedValue = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            date_Register.Value = DateTime.Parse(gridView1.GetFocusedRowCellValue("DATEREGISTER").ToString());
            num_Fare.Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FARE"));
        }
        /*
        private void cb_customer_Load()
        {
            cb_CusId.DataSource = customer.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} | {3,5} | {4,5}  ", row.ID_CUSTOMER, row.NAME, row.IDENTIFY,row.POSITION,row.ADDRESS),
                Value = row.ID_CUSTOMER
            }).ToList();

            cb_CusId.DisplayMember = "Text";
            cb_CusId.ValueMember = "Value";

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
        }
        */
        private void cb_sim_Load()
        {
            cb_SimId.DataSource = sim.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} |", row.ID_SIM, row.PHONENUMBER, row.STATUS),
                Value = row.ID_SIM
            }).ToList();

            cb_SimId.DisplayMember = "Text";
            cb_SimId.ValueMember = "Value";

            cb_SimId.SelectedItem = null;
            cb_SimId.Text = "Mã sim | Số điện thoại | Tình trạng";

        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = contract.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã hợp đồng";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Mã Sim";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Ngày đăng ký";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Phí đăng ký";
            ((GridView)gridControl1.MainView).Columns[4].Visible = false;
            Reset();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(contract.Update(txt_id.Text, cb_SimId.SelectedValue.ToString(), date_Register.Value, Convert.ToInt32(num_Fare.Value)));
            gridControl1.DataSource = contract.GetAll();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(contract.Update(txt_id.Text, cb_SimId.SelectedValue.ToString(), date_Register.Value, Convert.ToInt32(num_Fare.Value)));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            MessageBox.Show(contract.Update(txt_id.Text, cb_SimId.SelectedValue.ToString(), date_Register.Value, Convert.ToInt32(num_Fare.Value)));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cb_SimId.SelectedItem = null;
            cb_SimId.Text = "Mã sim | Số điện thoại | Tình trạng";
            
            /*
            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
            */

            txt_id.Text = ""; date_Register.Value = DateTime.Now; num_Fare.Value = 50000;
        }
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_id.Text == "")
                MessageBox.Show("Hãy chọn dữ liệu để xóa !");
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này ?",
                                            "Xác nhận xóa dữ liệu",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(contract.Delete(txt_id.Text));
                    gridControl1.DataSource = contract.GetAll();
                    Reset();
                }
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
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