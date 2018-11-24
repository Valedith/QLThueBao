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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.ContractGUI
{
    public partial class ContractCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ContractBUS contract = new ContractBUS();
        CustomerBUS customer = new CustomerBUS();
        SimBUS sim = new SimBUS();
        public ContractCreateInfoGUI()
        {
            InitializeComponent();
            cb_customer_Load();
            cb_sim_Load();

        }
        private void cb_customer_Load()
        {
            cb_CusId.DataSource = customer.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} | {3,5} | {4,5}  ", row.ID_CUSTOMER, row.NAME, row.IDENTIFY, row.POSITION, row.ADDRESS),
                Value = row.ID_CUSTOMER
            }).ToList();

            cb_CusId.DisplayMember = "Text";
            cb_CusId.ValueMember = "Value";

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
        }
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
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(contract.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(cb_SimId.SelectedValue), date_Register.Value, Convert.ToInt32(num_Fare.Value)));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(contract.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(cb_SimId.SelectedValue), date_Register.Value, Convert.ToInt32(num_Fare.Value)));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show(contract.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(cb_SimId.SelectedValue), date_Register.Value, Convert.ToInt32(num_Fare.Value)));
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

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";

            date_Register.Value = DateTime.Now; num_Fare.Value = 50000;
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