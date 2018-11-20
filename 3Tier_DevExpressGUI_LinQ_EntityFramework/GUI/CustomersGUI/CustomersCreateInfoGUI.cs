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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.CustomersGUI
{
    public partial class CustomersCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CustomerBUS customer = new CustomerBUS();
        public CustomersCreateInfoGUI()
        {
            InitializeComponent();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Create(txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text);
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Create(txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text);
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customer.Create(txt_name.Text, Convert.ToInt32(txt_iden.Text), txt_job.Text, txt_position.Text, txt_address.Text);
            txt_name.Text = ""; txt_job.Text = ""; txt_position.Text = ""; txt_address.Text = ""; txt_iden.Text = "";            
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_name.Text = ""; txt_job.Text = ""; txt_position.Text = ""; txt_address.Text = ""; txt_iden.Text = "";
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}