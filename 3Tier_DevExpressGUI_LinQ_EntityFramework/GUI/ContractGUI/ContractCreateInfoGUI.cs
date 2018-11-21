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
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            contract.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(cb_SimId.SelectedValue), date_Register.Value, Convert.ToInt32(num_Fare.Value));
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            contract.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(cb_SimId.SelectedValue), date_Register.Value, Convert.ToInt32(num_Fare.Value));
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            contract.Create(cb_CusId.SelectedValue.ToString(), Convert.ToInt32(cb_SimId.SelectedValue), date_Register.Value, Convert.ToInt32(num_Fare.Value));
            Reset();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cb_SimId.SelectedItem = null;
            cb_SimId.SelectedText = "Mã sim | Số điện thoại | Tình trạng";

            cb_CusId.SelectedItem = null;
            cb_CusId.SelectedText = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";

            date_Register.Value = DateTime.Now; num_Fare.Value = 50000;
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}